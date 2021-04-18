using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Netension.Extensions.Logging.Extensions
{
    public static class ILoggerExtensions
    {
        public static IDisposable BeginScope(this ILogger logger, string key, object value)
        {
            return logger.BeginScope(new Dictionary<string, object> { [key] = value });
        }
    }
}
