using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Business
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        T GetById(int Id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T obj);
        void AddRange(List<T> entities);
        void Remove(T obj);
        void RemoveRage(List<T> entities);
    }
}
