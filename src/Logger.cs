using Microsoft.Extensions.Logging;

namespace Sdt.Utils
{
    public class Logger
    {
        static ILoggerFactory _internalFactory;
        static ILogger _logger;
        static ILoggerFactory _factory {get{
            if ( _internalFactory == null)
               _internalFactory = new LoggerFactory().AddConsole();
            return _internalFactory;
        }}
        public static ILogger GetLogger<T> ()
        {
            return _factory.CreateLogger<T>();
        }
    }
}