using BookEntity.Logging.Interface;
using NLog;

namespace BookEntity.Logging
{
    public class LoggerManager : ILoggerManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public void LogInfo(string message) => logger.Info(message);
        public void LogError(string message) => logger.Error(message);
    }
}
