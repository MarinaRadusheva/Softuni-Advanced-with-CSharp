using Logger.Common;
using Logger.Core.Contracts;
using Logger.Factories;
using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using Logger.Models.Errors;

using System;
using System.Globalization;

namespace Logger.Core
{
    public class Engine : IEngine
    {
        private readonly ILogger logger;
        private readonly IReader reader;
        private readonly IWriter writer;
       
        public Engine(ILogger logger, IReader reader, IWriter writer)
        {
            this.logger = logger;
            this.reader = reader;
            this.writer = writer;
        }
        public void Run()
        {
            string command;
            while ((command =this.reader.ReadLine())!="END")
            {
                string[] commandInfo = command.Split('|');
                string levelInfo = commandInfo[0];
                string datetimeInfo = commandInfo[1];
                string messageInfo = commandInfo[2];
                    bool isValidLevel = Enum.TryParse(typeof(Level), levelInfo, true, out object levelObj);
                if (!isValidLevel)
                {
                    this.writer.WriteLine(GlobalConstants.INVALID_INPUT);
                    continue;
                }
                Level level = (Level)levelObj;
                bool isDateValid = DateTime.TryParseExact(datetimeInfo, GlobalConstants.DATETIME_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime datetime);
                if (!isDateValid)
                {
                    this.writer.WriteLine(GlobalConstants.INVALID_INPUT);
                    continue;
                }
                IError error = new Error(datetime, messageInfo, level);
                this.logger.Log(error);
            }
            this.writer.WriteLine(this.logger.ToString());
            
        }
    }
}
