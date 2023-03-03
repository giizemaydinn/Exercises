using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Challenge12.DataAccess
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T: class, new()
    {
        public void Add(T entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }

            //using (NorthwindContext context = new NorthwindContext())
            //{
            //    var addedEntity = context.Entry(entity);
            //    addedEntity.State = EntityState.Added;
            //    context.SaveChanges();
            //}
        }

        public async void Delete(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deleteEntity = await context.Set<T>().FindAsync(id);
                context.Set<T>().Remove(deleteEntity);
                var data = context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<T>().ToList()
                    : context.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //var updatedEntity = context.Entry(entity);
                //updatedEntity.State = EntityState.Modified;
                //context.SaveChanges();

                context.Set<T>().Update(entity);
                context.SaveChanges();
            }
        }
    }
}
