﻿#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion Using Directives

namespace Core.Infrastructure.Logging
{
    /// <summary>
    /// Abstract base implementation of a logger.
    /// </summary>
    public abstract class LoggerBase : ILogger
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoggerBase"/> class.
        /// </summary>
        /// <param name="type">The type to associate with the logger.</param>
        protected LoggerBase(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            Type = type;
        }

        /// <summary>
        /// Gets the type associated with the logger.
        /// </summary>
        public Type Type { get; private set; }

        /// <summary>
        /// Gets a value indicating whether messages with Debug severity should be logged.
        /// </summary>
        public abstract bool IsDebugEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether messages with Info severity should be logged.
        /// </summary>
        public abstract bool IsInfoEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether messages with Trace severity should be logged.
        /// </summary>
        public abstract bool IsTraceEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether messages with Warn severity should be logged.
        /// </summary>
        public abstract bool IsWarnEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether messages with Error severity should be logged.
        /// </summary>
        public abstract bool IsErrorEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether messages with Fatal severity should be logged.
        /// </summary>
        public abstract bool IsFatalEnabled { get; }

        /// <summary>
        /// Logs the specified message with Debug severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Debug(string format, params object[] args);

        /// <summary>
        /// Logs the specified exception with Debug severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Debug(Exception exception, string format, params object[] args);

        /// <summary>
        /// Logs the specified message with Info severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Info(string format, params object[] args);

        /// <summary>
        /// Logs the specified exception with Info severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Info(Exception exception, string format, params object[] args);

        /// <summary>
        /// Logs the specified message with Trace severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Trace(string format, params object[] args);

        /// <summary>
        /// Logs the specified exception with Trace severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Trace(Exception exception, string format, params object[] args);

        /// <summary>
        /// Logs the specified message with Warn severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Warn(string format, params object[] args);

        /// <summary>
        /// Logs the specified exception with Warn severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Warn(Exception exception, string format, params object[] args);

        /// <summary>
        /// Logs the specified message with Error severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Error(string format, params object[] args);

        /// <summary>
        /// Logs the specified exception with Error severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Error(Exception exception, string format, params object[] args);

        /// <summary>
        /// Logs the specified message with Fatal severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Fatal(string format, params object[] args);

        /// <summary>
        /// Logs the specified exception with Fatal severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Fatal(Exception exception, string format, params object[] args);
    }
}
