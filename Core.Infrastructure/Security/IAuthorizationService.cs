#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion Using Directives

namespace Core.Infrastructure.Security
{
    public interface IAuthorizationService
    {
        bool Authorize(IUser user, params IRole[] requiredRoles);
    }
}
