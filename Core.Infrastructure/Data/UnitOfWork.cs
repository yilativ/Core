#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion Using Directives

namespace Core.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContext context;
        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.context = databaseFactory.Get();
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
