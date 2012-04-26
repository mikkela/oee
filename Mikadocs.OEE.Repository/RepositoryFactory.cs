using System;
using System.Collections.Generic;
using System.Text;

using NHibernate;   

namespace Mikadocs.OEE.Repository
{
    public class RepositoryFactory : IDisposable
    {
        private readonly ISession _session;
        
        public RepositoryFactory()
        {
            _session = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory().OpenSession();
        }

        public IEntityRepository<TEntity> CreateEntityRepository<TEntity>() where TEntity : EntityObject
        {
            return new EntityRepository<TEntity>(_session);
        }

        public IProductionQueryRepository CreateProductionQueryRepository()
        {
            return new ProductionQueryRepository(_session);
        }

        #region IDisposable Members

        public void Dispose()
        {
            _session.Dispose();
        }

        #endregion
    }
}
