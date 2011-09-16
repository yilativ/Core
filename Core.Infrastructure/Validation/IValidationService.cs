#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion Using Directives

namespace Core.Infrastructure.Validation
{
    public interface IValidationService<T> : IValidationService where T : class
    {
        IValidationResult Validate(T entity);
    }

    public interface IValidationService
    {
        IValidationResult Validate(object entity);
    }
}