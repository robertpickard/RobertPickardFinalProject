using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ISfTE.DataAccess.Data.Repository.IRepository
{
    public interface IRepository<T> where T: class
    {
        //Get object by ID
        T Get(int id);

        //Get all objects as Ienumerable
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null);

        //Get the first/default object
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null);

        //Add
        void Add(T entity);

        //Remove(id)
        void Remove(int id);

        //Remove(object)
        void Remove(T entity);
        //Remove (list of objects)
        void RemoveRange(IEnumerable<T> entity);
    }
}
