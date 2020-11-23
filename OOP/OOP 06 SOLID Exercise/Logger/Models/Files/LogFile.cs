using Logger.Common;
using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Logger.Models.Files
{
    public class LogFile : IFile
    {
        private readonly IPathManager pathManager;
        public LogFile(IPathManager pathManager)
        {
            this.pathManager = pathManager;
            this.pathManager.EnsureDirectoryAndFileExist();
        }
        public string Path => this.pathManager.CurrentFilePath;

        public long Size => this.CalculateSize();

        public string Write(ILayout layout, IError error)
        {
            string format = layout.Format;
            string dateTime = error.Date.ToString(GlobalConstants.DATETIME_FORMAT, CultureInfo.InvariantCulture);
            string message = error.Message;
            Level level = error.Level;
            string formatedMessage = string.Format(format, dateTime, level, message);
            return formatedMessage;
        }
        private long CalculateSize()
        {
            string fileText = File.ReadAllText(this.Path);
            return fileText.ToCharArray().Where(x=>char.IsLetter(x)).Sum(x=>x);
        }
    }
}
