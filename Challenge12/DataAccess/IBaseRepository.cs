using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Challenge12.DataAccess
{
    public interface IBaseRepository<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
