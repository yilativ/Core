﻿#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Core.Infrastructure.Logging;
using Core.Infrastructure.Attributes;
#endregion Using Directives

namespace Core.Infrastructure.Data
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected readonly IDbContext context;
        protected readonly IDbSet<T> entities;

        [InjectDependency]
        public abstract ILogger Log { get; set; }

        public RepositoryBase(IDatabaseFactory databaseFactory)
        {
            this.context = databaseFactory.Get();
            this.entities = context.Set<T>();
        }

        public void Add(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            entities.Add(entity);
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            entities.Remove(entity);
        }

        public void Delete(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            foreach (T entity in entities.Where(where))
            {
                Delete(entity);
            }
        }

        public T GetById(int id)
        {
            return entities.Find(id);
        }

        public T GetByKey(params object[] keyValues)
        {
            return entities.Find(keyValues);
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            return entities.FirstOrDefault(where);
        }

        public IQueryable<T> GetAll()
        {
            return entities;
        }

        public IQueryable<T> GetWhere(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            return entities.Where(where);
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}