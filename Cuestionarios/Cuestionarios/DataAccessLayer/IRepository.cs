using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Cuestionarios.DataAccessLayer
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity pEntity);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        void Delete(TEntity pEntity);
    }
}
