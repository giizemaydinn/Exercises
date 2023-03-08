using Challenge16Entities;
using System.Linq.Expressions;

namespace Challenge16DataAccess
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class, IEntity, new()
    {
        List<T> list;

        public BaseRepository()
        {

            if (typeof(T).Name == typeof(Product).Name)
            {
                list = (List<T>)(object)DummyData.Products;
            }
            else if (typeof(T).Name == typeof(Category).Name)
            {
                list = (List<T>)(object)DummyData.Categories;

                //list = DummyData.Categories.Cast<T>().ToList();
            }
        }
        public async Task<List<T>> GetAll(Expression<Func<T, bool>> filter = null)
        {
            if (filter != null)
            {
                return list.AsQueryable().Where(filter).ToList();

            }
            return list;

        }

        public async Task<T> GetById(Expression<Func<T, bool>> filter)
        {
            var entity = list.AsQueryable().Where(filter).FirstOrDefault();

            return entity;

        }

        public async Task<bool> Add(T entity)
        {
            entity.Id = list.Count;
            list.Add(entity);

            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = list.FirstOrDefault(x => x.Id == id);

            if (entity != null)
                list.Remove(entity);

            return true;
        }

        public async Task<bool> Update(T entity)
        {
            int index = list.FindIndex(x => x.Id == entity.Id);
            list[index] = entity;

            return true;
            //return new Response(false, "Ekleme başarısız.", 400);
        }




    }
}
