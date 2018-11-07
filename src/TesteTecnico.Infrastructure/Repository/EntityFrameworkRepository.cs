using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TesteTecnico.Infrastructure.Data;
using TesteTecnico.ApplicationCore.Interfaces.Repository;

namespace TesteTecnico.Infrastructure.Repository
{
    public class EntityFrameworkRepository<TEntity> : IRepositorioBase<TEntity> where TEntity : class
    {
        /*
         * Injetando Dependência do Context
         * 
         */
        protected readonly TesteTecnicoContext _DbContext;

        public EntityFrameworkRepository(TesteTecnicoContext context)
        {
            _DbContext = context;
        }

        public virtual TEntity Add(TEntity obj)
        {
            _DbContext.Set<TEntity>().Add(obj);
            _DbContext.SaveChanges();
            return obj;
        }

        public virtual void Update(TEntity obj)
        {
            _DbContext.Entry(obj).State = EntityState.Modified;
            _DbContext.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            _DbContext.Set<TEntity>().Remove(obj);
            _DbContext.SaveChanges();
        }

        public virtual TEntity GetById(int id)
        {
            return _DbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAllAsNoTracking()
        {
            return _DbContext.Set<TEntity>().AsNoTracking().AsEnumerable();
        }

        public IEnumerable<TEntity> Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicado)
        {
            return _DbContext.Set<TEntity>().Where(predicado).AsEnumerable();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
