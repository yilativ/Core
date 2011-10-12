#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Infrastructure.Data;
using Core.Infrastructure.Logging;
using Core.Infrastructure.Attributes;
#endregion Using Directives

namespace Core.Service.Infrastructure
{
    public abstract class ServiceBase<T, TRepository> : IServiceBase<T>
        where T : class
        where TRepository : IRepository<T>
    {
        protected readonly TRepository repository;

        [InjectDependency]
        public abstract ILogger Log { get; set; }

        public ServiceBase(TRepository repository)
        {
            this.repository = repository;
        }

        public virtual T GetItem(int id)
        {
            return repository.GetById(id);
        }

        public IQueryable<T> GetItems()
        {
            return repository.GetAll();
        }

        public virtual void Create(T item)
        {
            repository.Add(item);
        }

        public virtual void Delete(int id)
        {
            T item = GetItem(id);
            if (item == null)
                throw new NullReferenceException("Attempting to delete item that does not exist.");

            repository.Delete(item);
        }

        public void SaveChanges()
        {
            repository.SaveChanges();
        }
    }
}