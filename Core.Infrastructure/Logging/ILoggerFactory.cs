#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion Using Directives

namespace Core.Infrastructure.Logging
{
    /// <summary>
    /// Factory interface for loggers.
    /// </summary>
    public interface ILoggerFactory
    {
        ILogger GetLogger(Type type);

#if !SILVERLIGHT && !NETCF
        ILogger GetCurrentClassLogger();
#endif
    }
}
