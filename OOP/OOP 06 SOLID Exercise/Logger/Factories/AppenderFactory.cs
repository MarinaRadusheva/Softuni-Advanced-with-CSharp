using Logger.Common;
using Logger.Models.Appenders;
using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Factories
{
    public class AppenderFactory
    {
        public AppenderFactory()
        {

        }
        public IAppender CreateAppender(string appenderTypeInput, ILayout layout, Level level, IFile file = null)
        {
            IAppender appender;
            if (appenderTypeInput == "ConsoleAppender")
            {
                appender = new ConsoleAppender(layout, level);
            }
            else if (appenderTypeInput=="FileAppender"&&file!=null)
            {
                appender = new FileAppender(layout, level, file);
            }
            else
            {
                throw new InvalidOperationException(GlobalConstants.INVALID_INPUT);
            }
            return appender;
        }
    }
}
