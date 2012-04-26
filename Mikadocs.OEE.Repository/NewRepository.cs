using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;

namespace Mikadocs.OEE.Repository
{
    public class NewRepository : IDisposable
    {
        private readonly ISession _session;
        private ITransaction transaction;

        public NewRepository()
        {
            _session = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory().OpenSession();
        }

        public void BeginTransaction()
        {
            transaction = _session.BeginTransaction();
        }

        public void Save<TObject>(IEnumerable<TObject> objects)
        {
            try
            {
                foreach (var o in objects)
                {
                    _session.SaveOrUpdate(o);
                }
            }
            catch (HibernateException e)
            {
                transaction.Rollback();
                _session.Clear();
                throw new RepositoryException("Could not save the entity due to an internal exception", e);
            }
        }

        public void Delete(object entity)
        {
            try
            {
                _session.Delete(entity);
            }
            catch (HibernateException e)
            {
                transaction.Rollback();
                _session.Clear();
                throw new RepositoryException("Could not delete the entity due to an internal exception", e);
            }
        }

        public IEnumerable<TEntity> LoadAll<TEntity>()
        {
            IList<TEntity> result;

            try
            {
                ICriteria criteria = _session.CreateCriteria(typeof(TEntity));
                criteria.SetMaxResults(50);
                criteria.AddOrder(new NHibernate.Criterion.Order("Id", false));

                result = criteria.List<TEntity>();
            }
            catch (HibernateException e)
            {
                result = new List<TEntity>();               
            }

            return result;
        }

        public void Commit()
        {
            transaction.Commit();
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (transaction != null)
                transaction.Dispose();
            _session.Dispose();
        }

        #endregion
    }
}
