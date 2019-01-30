using System;
using System.Linq;
using System.Linq.Expressions;

namespace Example.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);

        void Update(T entity);

        T Delete(T entity);

        T Delete(long id);

        void DeleteMulti(Expression<Func<T, bool>> where);

        T GetSingleById(long id);

        T GetSingleById(string id);

        IQueryable<T> GetAll(string[] sort = null, string sortType = "");

        IQueryable<T> GetAll(Expression<Func<T, bool>> filter, string[] includes = null, string[] sort = null, string sortType = "");

        IQueryable<T> GetPaging(Expression<Func<T, bool>> filter, string[] sort, out int total, out int itemStart, out int itemEnd, int index = 0, int size = 50, bool notPading = false, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);

        T GetFirstOrDefault(Expression<Func<T, bool>> fillter);

        bool CheckContains(Expression<Func<T, bool>> predicate);

            
    }
}