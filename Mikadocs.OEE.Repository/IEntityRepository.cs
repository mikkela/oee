using System.Collections.Generic;

namespace Mikadocs.OEE.Repository
{
    public interface IEntityRepository
    {
        void Save<TEntity>(TEntity entity) where TEntity : EntityObject;
        void SaveAll<TEntity>(IEnumerable<TEntity> entities) where TEntity : EntityObject;

        TEntity Load<TEntity>(long id) where TEntity : EntityObject;
        IEnumerable<TEntity> LoadAll<TEntity>() where TEntity : EntityObject;

        void Delete<TEntity>(TEntity entity) where TEntity : EntityObject;
    }
}
