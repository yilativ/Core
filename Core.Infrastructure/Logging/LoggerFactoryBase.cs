#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Diagnostics;
#endregion Using Directives

namespace Core.Infrastructure.Logging
{
    /// <summary>
    /// A baseline definition of a logger factory, which tracks loggers as flyweights by type.
    /// Custom logger factories should generally extend this type.
    /// </summary>
    public abstract class LoggerFactoryBase : ILoggerFactory
    {
        /// <summary>
        /// Maps types to their loggers.
        /// </summary>
        private readonly ConcurrentDictionary<Type, ILogger> loggers = new ConcurrentDictionary<Type, ILogger>();

        /// <summary>
        /// Gets the logger for the specified type, creating it if necessary.
        /// </summary>
        /// <param name="type">The type to create the logger for.</param>
        /// <returns>The newly-created logger.</returns>
        public ILogger GetLogger(Type type)
        {
            if (this.loggers.ContainsKey(type))
            {
                return this.loggers[type];
            }

            ILogger logger;
            if (this.loggers.TryGetValue(type, out logger))
                return logger;

            logger = this.CreateLogger(type);
            this.loggers[type] = logger;
            return logger;
        }

#if !SILVERLIGHT && !NETCF
        /// <summary>
        /// Gets the logger for the class calling this method.
        /// </summary>
        /// <returns>The newly-created logger.</returns>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public ILogger GetCurrentClassLogger()
        {
            var frame = new StackFrame(1, false);
            return this.GetLogger(frame.GetMethod().DeclaringType);
        }
#endif

        /// <summary>
        /// Creates a logger for the specified type.
        /// </summary>
        /// <param name="type">The type to create the logger for.</param>
        /// <returns>The newly-created logger.</returns>
        protected abstract ILogger CreateLogger(Type type);
    }
}
