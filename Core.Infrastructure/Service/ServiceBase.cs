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
    public class ServiceBase<T, TRepository> : IServiceBase<T>
        where T : class
        where TRepository : IRepository<T>
    {
        protected readonly TRepository repository;
        protected readonly IUnitOfWork unitOfWork;

        [InjectDependency]
        public virtual ILogger Log { get; set; }

        public ServiceBase(TRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public virtual T GetItem(int id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<T> GetItems()
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

        public virtual void Save()
        {
            unitOfWork.Commit();
        }
    }
}
