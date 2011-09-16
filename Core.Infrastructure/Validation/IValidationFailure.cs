#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion Using Directives

namespace Core.Infrastructure.Validation
{
    public interface IValidationFailure
    {
        object CustomState { get; set; }
        object AttemptedValue { get; }
        string ErrorMessage { get; }
        IEnumerable<string> MemberNames { get; set; }
    }
}