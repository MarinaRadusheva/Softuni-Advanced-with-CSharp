using Logger.Common;
using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using Logger.Models.IOManager;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Logger.Models.Appenders
{
    public class ConsoleAppender : IAppender
    {
        private readonly IWriter writer;
        private int appendedMessages;
        private ConsoleAppender()
        {
            this.writer = new ConsoleWriter();
        }
        public ConsoleAppender(ILayout layout, Level treshold) : this()
        {
            this.Layout = layout;
            this.Tresholdlevel = treshold;
        }
        public ILayout Layout { get; }

        public Level Tresholdlevel { get; }

        public void Append(IError error)
        {
            string format = this.Layout.Format;
            string dateTime = error.Date.ToString(GlobalConstants.DATETIME_FORMAT,CultureInfo.InvariantCulture);
            string message = error.Message;
            Level errorlevel = error.Level;
            string lineToAppend = String.Format(format, dateTime, errorlevel.ToString(), message);
            this.writer.WriteLine(lineToAppend);
            this.appendedMessages++;
        }
        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.Tresholdlevel}, Messages appended: {appendedMessages}";
        }
    }
}
