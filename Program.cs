using System;
using System.Threading;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace stack_exchange_redis
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerFactory loggerFactory = new LoggerFactory().AddConsole();
            
            ILogger logger = loggerFactory.CreateLogger<Program>();
            int maxWorkerThreads;
            int maxCompletionPortThreads;

            ThreadPool.GetMaxThreads(out maxWorkerThreads,out maxCompletionPortThreads);
            logger.LogInformation("Hola");
            logger.LogDebug("Que tal!");
        }
    }
}
