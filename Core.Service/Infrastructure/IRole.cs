#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion Using Directives

namespace Core.Security.Infrastructure
{
    public interface IRole
    {
        string Name { get; set; }
    }
}
