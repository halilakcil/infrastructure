using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcern.Logging.Log4Net.Loggers
{
    public class FileLogger : LoggerServiceBase
    {
        public FileLogger() : base("JsonFileLogger")//look at log4net.config for JsonFileLogger
        {
        }
    }
}
