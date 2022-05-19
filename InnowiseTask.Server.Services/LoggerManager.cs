using InnowiseTask.Server.Services.Interfaces;
using NLog;

namespace InnowiseTask.Server.Services
{
    public class LoggerManager : ILoggerManager
    {
        private readonly static ILogger logger = LogManager.GetCurrentClassLogger();
        public LoggerManager()
        {
        }

        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        public void LogError(string message)
        {
            logger.Error(message);
        }

        public void LogInfo(string message)
        {
            logger.Info(message);
        }

        public void LogWarning(string message)
        {
            logger.Warn(message);
        }
    }
}
