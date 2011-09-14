#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Objects;
using Core.Infrastructure.Logging;
using Core.Infrastructure.Attributes;
#endregion Using Directives

namespace Core.Infrastructure.Data
{
    public abstract class DbContextBase : DbContext, IDbContext
    {
        protected readonly IConnectionFactory connectionFactory;

        public DbContextBase(IConnectionFactory connectionFactory)
            : base(connectionFactory.GetNameOrConnectionString())
        {
            this.connectionFactory = connectionFactory;
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}