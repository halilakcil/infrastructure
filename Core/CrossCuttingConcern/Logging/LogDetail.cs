using System.Collections.Generic;

namespace Core.CrossCuttingConcern.Logging
{
    public class LogDetail
    {
        public string MethodName { get; set; }
        public List<LogParameter> LogParameters { get; set; }
    }
}
