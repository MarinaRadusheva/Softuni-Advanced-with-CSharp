using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using Logger.Models.Managing;
using System;
using System.Collections.Generic;
using Logger.Common;
using Logger.Factories;
using Logger.Models.Files;
using Logger.Models.IOManager;
using Logger.Core.Contracts;
using Logger.Core;

namespace Logger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IPathManager pathManager = new PathManager("LoggerProblem", "Loggerfile.txt");
            IFile file = new LogFile(pathManager);
            ILogger logger = CreateLogger(n, reader, writer, file, new LayoutFactory(), new AppenderFactory());
            IEngine engine = new Engine(logger, reader, writer);
            engine.Run();
        }
        private static ILogger CreateLogger(int appendersCount, IReader reader, IWriter writer, IFile file, LayoutFactory layoutFactory, AppenderFactory appenderFactory)
        {
            ICollection<IAppender> appenders = new List<IAppender>();
            for (int i = 0; i < appendersCount; i++)
            {
                string[] appenderInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string appenderType = appenderInfo[0];
                string layoutType = appenderInfo[1];
                Level appenderTreshold = Level.INFO;
                if (appenderInfo.Length==3)
                {
                    bool isValidLevel = Enum.TryParse(typeof(Level), appenderInfo[2], true, out object enumParsed);
                    if (!isValidLevel)
                    {
                        writer.WriteLine(GlobalConstants.INVALID_INPUT);
                    }
                    else
                    {
                        appenderTreshold = (Level)enumParsed;
                    }
                }
                try
                {
                    ILayout layout = layoutFactory.CreateLayout(layoutType);
                      IAppender appender = appenderFactory.CreateAppender(appenderType, layout, appenderTreshold, file);
                        appenders.Add(appender);
                }
                catch (InvalidOperationException e)
                {

                    Console.WriteLine(e.Message);
                }
               
            }
            ILogger logger = new Logger.Models.Logger(appenders);
            return logger;
        }
    }
}
