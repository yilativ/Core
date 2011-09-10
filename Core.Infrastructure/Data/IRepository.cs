#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
#endregion Using Directives

namespace Core.Infrastructure.Data
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        T GetById(int id);
        T Get(Expression<Func<T, bool>> where);
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> where);
    }
}
