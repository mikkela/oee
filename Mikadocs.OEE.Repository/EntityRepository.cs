using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using NHibernate;
using NHibernate.Criterion;

namespace Mikadocs.OEE.Repository
{
    class EntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : EntityObject
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private ISession session;

        public EntityRepository(ISession session)
        {
            this.session = session;
        }

        #region IEntityRepository<TEntity> Members

        public void Save(TEntity entity)
        {
            log.InfoFormat("Saving entity: {0}", entity);
            bool done = false;

            while (!done)
            {
                try
                {
                    using (ITransaction tx = session.BeginTransaction())
                    {
                        try
                        {
                            session.SaveOrUpdate(entity);
                            tx.Commit();
                            done = true;
                        }
                        catch (HibernateException e)
                        {
                            log.Error(
                                string.Format(
                                    "An exception occurred while saving entity: {0}. The entity is not saved.",
                                    entity), e);
                            tx.Rollback();
                            session.Clear();
                            throw new RepositoryException("Could not save the entity due to an internal exception", e);
                        }
                    }
                } catch(Exception e)
                {
                    while (true) {
                        try
                        {
                            System.Threading.Thread.Sleep(1000);
                            if (session.Connection.State == ConnectionState.Closed ||
                                session.Connection.State == ConnectionState.Broken)
                                session.Connection.Open();
                            break;
                        }catch
                        {
                        }
                    }
                    }

            }
            log.InfoFormat("Saved entity: {0}", entity);
        }

        public void Delete(TEntity entity)
        {
            log.InfoFormat("Deleting entity: {0}", entity);

            using (ITransaction tx = session.BeginTransaction())
            {
                try
                {
                    session.Delete(entity);
                    tx.Commit();
                }
                catch (HibernateException e)
                {
                    log.Error(string.Format("An exception occurred while deleting entity: {0}. The entity is not saved.", entity), e);
                    tx.Rollback();
                    session.Clear();
                    throw new RepositoryException("Could not delete the entity due to an internal exception", e);
                }
            }

            log.InfoFormat("Deleted entity: {0}", entity);
        }

        public TEntity Load(long id)
        {
            log.InfoFormat("Loading entity with id: {0} of type: {1}", id, typeof(TEntity).Name);
            TEntity result = null;

            try
            {
                ICriteria criteria = session.CreateCriteria(typeof(TEntity));
                criteria.Add(Expression.Eq("Id", id));

                result = criteria.UniqueResult<TEntity>();

            }
            catch (HibernateException e)
            {
                log.Error(string.Format("An exception occurred while loading entity with id: {0}. The entity is not loaded.", id), e);

                throw new RepositoryException("Could not load the entity due to an internal exception", e);
            }


            if (result != null)
                log.InfoFormat("Loaded entity with id: {0} of type {1}. Result is: {2}", id, typeof(TEntity).Name, result);
            else
                log.InfoFormat("Loaded entity with id: {0} of type {1}. No entity were found", id, typeof(TEntity).Name);

            return result;
        }

        public IEnumerable<TEntity> LoadAll()
        {
            log.InfoFormat("Loading all entities of type: {0}", typeof(TEntity).Name);

            IList<TEntity> result;

            try
            {
                ICriteria criteria = session.CreateCriteria(typeof(TEntity));
                criteria.AddOrder(new NHibernate.Criterion.Order("Id", true));

                result = criteria.List<TEntity>();
            }
            catch (HibernateException e)
            {
                log.Error(string.Format("An exception occurred while loading all entities of type: {0}. No entities were loaded.", typeof(TEntity).Name), e);
                result = new List<TEntity>();
                //throw new RepositoryException("Could not load all entities due to an internal exception", e);
            }

            log.InfoFormat("Loaded all entities of type: {0}. {1} entities were found", typeof(TEntity).Name, result.Count);
            return result;
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {            
        }

        #endregion
    }
}
