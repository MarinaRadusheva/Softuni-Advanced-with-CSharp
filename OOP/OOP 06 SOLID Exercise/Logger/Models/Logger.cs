using Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logger.Models
{
    public class Logger : ILogger
    {
        private readonly ICollection<IAppender> appenders;
        public Logger(ICollection<IAppender> appenders)
        {
            this.appenders = appenders;
        }
        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }
        public IReadOnlyCollection<IAppender> Appenders => (IReadOnlyCollection<IAppender>)this.appenders;

        public void Log(IError error)
        {
            foreach (var appender in this.Appenders)
            {
                if (error.Level>= appender.Tresholdlevel)
                {
                    appender.Append(error);
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Logger info");
            foreach (var item in this.Appenders)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
