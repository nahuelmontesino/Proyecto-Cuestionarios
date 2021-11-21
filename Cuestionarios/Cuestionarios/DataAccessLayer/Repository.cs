using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Cuestionarios.Models.DAL
{
    public abstract class Repository<TEntity, TDbContext>: IRepository<TEntity>
        where TEntity: class
        where TDbContext: DbContext
    {
        protected readonly TDbContext iDbContext;
        protected readonly DbSet<TEntity> dbSet;

        public Repository(TDbContext pContext)
        {
            iDbContext = pContext;
            dbSet = pContext.Set<TEntity>();
        }

        /// <summary>
        /// Adds an entity
        /// </summary>
        public void Add(TEntity pEntity)
        {
            dbSet.Add(pEntity);
        }

        public IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
                IQueryable<TEntity> query = dbSet;

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                if (orderBy != null)
                {
                    return orderBy(query).ToList();
                }
                else
                {
                    return query.ToList();
                }
        }


        /// <summary>
        /// Delete an entity
        /// </summary>
        public void Delete(TEntity pEntity)
        {
            if (iDbContext.Entry(pEntity).State == EntityState.Detached)
            {
                dbSet.Attach(pEntity);
            }

            dbSet.Remove(pEntity);
        }
    }
}
