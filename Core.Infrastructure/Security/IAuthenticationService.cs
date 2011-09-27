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
        bool Login(string username, bool rememberMe, string friendlyName);
        bool Logout(string username);
    }
}