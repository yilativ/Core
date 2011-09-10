#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Objects;
using Core.Infrastructure.Logging;
#endregion Using Directives

namespace Core.Infrastructure.Data
{
    public class DbContextBase : DbContext, IDbContext
    {
        protected readonly IConnectionFactory connectionFactory;
        protected readonly ILogger log;

        public DbContextBase(IConnectionFactory connectionFactory, ILogger log)
            : base(connectionFactory.GetNameOrConnectionString())
        {
            this.connectionFactory = connectionFactory;
            this.log = log;
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}