using System;
using System.Collections.Generic;
using System.Data;
using NHibernate;
using NHibernate.Criterion;

namespace Mikadocs.OEE.Repository
{
    public class EntityRepository : IEntityRepository
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly ISession _session;

        public EntityRepository(ISession session)
        {
            _session = session;
        }

        public void Save<TEntity>(TEntity entity) where TEntity : EntityObject
        {
            bool done = false;

            while (!done)
            {
                done = SaveInTransactrion(new [] {entity});
                if (!done)
                {
                    Wait();
                }

            }
        }

        public void SaveAll<TEntity>(IEnumerable<TEntity> entities) where TEntity : EntityObject
        {
            SaveInTransactrion(entities);
        }

        private bool SaveInTransactrion<TEntity>(IEnumerable<TEntity> entities)
        {
            using (ITransaction tx = _session.BeginTransaction())
            {
                try
                {
                    foreach (var entity in entities)
                    {
                        _session.SaveOrUpdate(entity);    
                    }
                    
                    tx.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    Log.Error("Unable to save entities", e);
                    tx.Rollback();
                    _session.Clear();
                    return false;
                }
            }            
        }

        private void Wait()
        {
            try
            {
                System.Threading.Thread.Sleep(1000);
                if (_session.Connection.State == ConnectionState.Closed ||
                    _session.Connection.State == ConnectionState.Broken)
                    _session.Connection.Open();                
            }
            catch
            {
            }
        }

        public TEntity Load<TEntity>(long id) where TEntity : EntityObject
        {
            try
            {
                ICriteria criteria = _session.CreateCriteria(typeof(TEntity));
                criteria.Add(Restrictions.Eq("Id", id));

                return criteria.UniqueResult<TEntity>();

            }
            catch (HibernateException e)
            {
                Log.Error(string.Format("An exception occurred while loading entity with id: {0}. The entity is not loaded.", id), e);

                throw new RepositoryException("Could not load the entity due to an internal exception", e);
            }
        }

        public IEnumerable<TEntity> LoadAll<TEntity>() where TEntity : EntityObject
        {
            try
            {
                ICriteria criteria = _session.CreateCriteria(typeof(TEntity));
                criteria.AddOrder(new Order("Id", true));

                return criteria.List<TEntity>();
            }
            catch (HibernateException e)
            {
                Log.Error(string.Format("An exception occurred while loading all entities of type: {0}. No entities were loaded.", typeof(TEntity).Name), e);
                return new List<TEntity>();                
            }
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : EntityObject
        {
            using (ITransaction tx = _session.BeginTransaction())
            {
                try
                {
                    _session.Delete(entity);
                    tx.Commit();
                }
                catch (HibernateException e)
                {
                    Log.Error(string.Format("An exception occurred while deleting entity: {0}. The entity is not saved.", entity), e);
                    tx.Rollback();
                    _session.Clear();
                    throw new RepositoryException("Could not delete the entity due to an internal exception", e);
                }
            }            
        }

    }
   
}
