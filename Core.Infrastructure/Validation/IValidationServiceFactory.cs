#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion Using Directives

namespace Core.Infrastructure.Validation
{
    public interface IValidationServiceFactory
    {
        IValidationService<T> GetValidationService<T>() where T : class;
        IValidationService GetValidationService(Type type);
    }
}
