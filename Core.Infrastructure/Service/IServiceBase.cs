#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion Using Directives

namespace Core.Service.Infrastructure
{
    public interface IServiceBase<T> : IDisposable
    {
        T GetItem(int id);

        IEnumerable<T> GetItems();

        void Create(T item);
        void Delete(int id);
        void Commit();
    }
}