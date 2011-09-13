#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion Using Directives

namespace Core.Infrastructure.Security
{
    public interface IAuthenticationService
    {
        bool Login(IUser user, bool rememberMe);
        bool Logout(IUser user);
    }
}