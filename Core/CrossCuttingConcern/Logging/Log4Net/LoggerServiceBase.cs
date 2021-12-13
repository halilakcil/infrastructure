using System.IO;
using System.Reflection;
using System.Xml;
using log4net;
using log4net.Repository;

namespace Core.CrossCuttingConcern.Logging.Log4Net
{
    public abstract class LoggerServiceBase
    {
        private ILog _log;
        protected LoggerServiceBase(string name)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(File.OpenRead("log4net.config"));

            var loggerRepository = LogManager.CreateRepository(Assembly.GetEntryAssembly(), typeof(log4net.Repository.Hierarchy.Hierarchy));
            log4net.Config.XmlConfigurator.Configure(loggerRepository, xmlDocument["log4net"]);

            _log = LogManager.GetLogger(loggerRepository.Name, name);
        }

        public bool IsInfoEnabled => _log.IsInfoEnabled;
        public bool IsDebugEnabled => _log.IsDebugEnabled;
        public bool IsWarnEnabled => _log.IsWarnEnabled;
        public bool IsFatalEnabled => _log.IsFatalEnabled;
        public bool IsErrorEnabled => _log.IsErrorEnabled;

        public void Info(string logMessage)
        {
            if (IsInfoEnabled)
                _log.Info(logMessage);
        }
        public void Debug(string logMessage)
        {
            if (IsDebugEnabled)
                _log.Debug(logMessage);
        }
        public void Warn(string logMessage)
        {
            if (IsWarnEnabled)
                _log.Warn(logMessage);
        }
        public void Fatal(string logMessage)
        {
            if (IsFatalEnabled)
                _log.Fatal(logMessage);
        }
        public void Error(string logMessage)
        {
            if (IsErrorEnabled)
                _log.Error(logMessage);
        }
    }
}
