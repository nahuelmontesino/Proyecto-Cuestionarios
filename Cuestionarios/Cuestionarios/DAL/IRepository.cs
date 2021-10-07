﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Cuestionarios.DAL
{
    public interface IRepository<TEntity> where TEntity: class
    {
        void Add(TEntity pEntity);
        TEntity GetByID(int pId);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        void Update(TEntity entityToUpdate);
        void Delete(TEntity pEntity);
    }
}
