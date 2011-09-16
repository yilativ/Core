#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Infrastructure.Data;
#endregion Using Directives

namespace Core.Service.Infrastructure
{
    public interface IServiceBase<T> : IUnitOfWork, IDisposable
    {
        T GetItem(int id);

        IEnumerable<T> GetItems();

        void Create(T item);
        void Delete(int id);
    }
}