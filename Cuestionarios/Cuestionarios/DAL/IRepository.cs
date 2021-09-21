
using System.Collections.Generic;


namespace Cuestionarios.DAL
{
    interface IRepository<TEntity> where TEntity: class
    {
        void Add(TEntity pEntity);
        void Remove(TEntity pEntity);
        TEntity GetByID(int pId);
        IEnumerable<TEntity> GetAll();
    }
}
