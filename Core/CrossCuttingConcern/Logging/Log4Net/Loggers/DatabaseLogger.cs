namespace Core.CrossCuttingConcern.Logging.Log4Net.Loggers
{
    public class DatabaseLogger : LoggerServiceBase
    {
        public DatabaseLogger() : base("DatabaseLogger")//look at log4net.config for DatabaseLogger
        {
        }
    }
}
