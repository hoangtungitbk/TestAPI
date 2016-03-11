using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Business
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext context;
        public Repository(DbContext context)
        {
            this.context = context;
        }
        public IEnumerable<T> Get()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int Id)
        {
            return context.Set<T>().Find(Id);
        }

        public IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate);
        }

        public void Add(T obj)
        {
            context.Set<T>().Add(obj);
        }

        public void AddRange(List<T> entities)
        {
            context.Set<T>().AddRange(entities);
        }

        public void Remove(T obj)
        {
            context.Set<T>().Remove(obj);
        }

        public void RemoveRage(List<T> entities)
        {
            context.Set<T>().RemoveRange(entities);
        }
    }
}
