using System;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace TesteTecnico.ApplicationCore.Interfaces.Repository
{
    /*
     * Interface com métodos genéricos para realiar o CRUD
     * Usando TEntity como classe anônima
     * 
     */
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAllAsNoTracking();
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicado);
        void Dispose();
    }
}
