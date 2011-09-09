#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
#endregion Using Directives

namespace Core.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}