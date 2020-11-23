using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using Logger.Models.IOManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models.Appenders
{
    public class FileAppender : IAppender
    {
        private readonly IWriter writer;
        private int appendedMessages;
        //public FileAppender()
        //{
        //    this.writer = new FileWriter(this.File.Path);
        //}
        public FileAppender(ILayout layout, Level treshold, IFile file) //:this()
        {
            this.Layout = layout;
            this.Tresholdlevel = treshold;
            this.File = file;
            this.writer = new FileWriter(this.File.Path);
        }
        public ILayout Layout { get; }

        public Level Tresholdlevel { get; }
        public IFile File { get; }

        public void Append(IError error)
        {
            string lineToAppend = this.File.Write(this.Layout, error);
            this.writer.WriteLine(lineToAppend);
            this.appendedMessages++;
        }
        public override string ToString()
        {
            return $"Logger info{Environment.NewLine}Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.Tresholdlevel}, Messages appended: {appendedMessages}, File size {this.File.Size}";
        }
    }
}
