using System;
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

        public IEntityRepository CreateEntityRepository()
        {
            return new EntityRepository(_session);
        }

        public IProductionQueryRepository CreateProductionQueryRepository(bool doDuplicate)
        {
            return new ProductionQueryRepository(_session, doDuplicate);
        }


        #region IDisposable Members

        public void Dispose()
        {
            _session.Dispose();
        }

        #endregion
    }
}
