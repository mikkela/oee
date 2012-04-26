using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE.Repository
{
    public interface IEntityRepository<TEntity> :IDisposable where TEntity : EntityObject
    {
        void Save(TEntity entity);
        
        TEntity Load(long id);
        void Delete(TEntity entity);

        IEnumerable<TEntity> LoadAll();
    }
}
