using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using System;

namespace Logger.Models.Errors
{
    public class Error : IError
    {
        public Error(DateTime dateTime, string message, Level level)
        {
            this.Date = dateTime;
            this.Message = message;
            this.Level = level;
        }
        public DateTime Date { get; }

        public string Message { get; }

        public Level Level { get; }
    }
}
