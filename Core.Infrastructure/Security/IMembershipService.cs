#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion Using Directives

namespace Core.Infrastructure.Security
{
    public interface IMembershipService
    {
        bool ValidateUser(string username, string password, out IUser user);
        bool ChangePassword(string username, string oldPassword, string newpassword);
    }
}