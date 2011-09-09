#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
#endregion Using Directives

namespace Core.Data.Infrastructure
{
    public class DbContextBase : DbContext, IDbContext
    {
        public const string ConstructorParameterName = "nameOrConnectionString";

        public DbContextBase(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}