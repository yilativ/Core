#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Security.Infrastructure;
#endregion Using Directives

namespace Core.Service.Security
{
    public interface IAuthorizationService
    {
        bool Authorize(IUser user, params IRole[] requiredRoles);
    }
}
