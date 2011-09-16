#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion Using Directives

namespace Core.Infrastructure.Validation
{
    public interface IValidationResult
    {
        IList<IValidationFailure> Errors { get; }
        bool IsValid { get; }
    }
}
