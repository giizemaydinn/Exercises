using System.Linq.Expressions;

namespace Challenge16DataAccess
{
    public interface IBaseRepository<T>
    {
        public Task<List<T>> GetAll(Expression<Func<T, bool>> filter);
        public Task<bool> Add(T entity);
        public Task<T> GetById(Expression<Func<T, bool>> filter);
        public Task<bool> Update(T entity);
        public Task<bool> Delete(int id);
    }
}
