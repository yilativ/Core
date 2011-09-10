#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion Using Directives

namespace Core.Infrastructure.Security
{
    public interface IUser
    {
        string Username { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
