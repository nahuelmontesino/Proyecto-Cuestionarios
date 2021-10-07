using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Cuestionarios.DAL.EntityFramework
{
    public abstract class Repository<TEntity, TDbContext>: IRepository<TEntity>
        where TEntity: class
        where TDbContext: DbContext
    {
        protected readonly TDbContext iDbContext;
        protected readonly DbSet<TEntity> dbSet;

        public Repository(TDbContext pContext)
        {
            try
            {
                iDbContext = pContext;
                dbSet = pContext.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw new NpgsqlException(ex.ToString());
            }
        }

        /// <summary>
        /// Adds an entity
        /// </summary>
        public void Add(TEntity pEntity)
        {
            try
            {
                dbSet.Add(pEntity);
            }
            catch (Exception ex)
            {
                throw new NpgsqlException(ex.ToString());
            }

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
        /// Gets the entity by its id
        /// </summary>
        public TEntity GetByID(int pId)
        {
            try
            {
                return dbSet.Find(pId);
            }
            catch (Exception ex)
            {
                throw new NpgsqlException(ex.ToString());
            }

        }

        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            iDbContext.Entry(entityToUpdate).State = EntityState.Modified;
        }


        /// <summary>
        /// Delete an entity
        /// </summary>
        public void Delete(TEntity pEntity)
        {
            try
            {
                if (iDbContext.Entry(pEntity).State == EntityState.Detached)
                {
                    dbSet.Attach(pEntity);
                }

                dbSet.Remove(pEntity);
            }
            catch (Exception ex)
            {
                throw new NpgsqlException(ex.ToString());
            }

        }
    }
}
