using CommandPattern.Core.Contracts;
using CommandPattern.Models;

namespace CommandPattern.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader = new ConsoleReader();
        private readonly IWriter writer = new ConsoleWriter();
        private readonly ICommandInterpreter commandInterpreter;
        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }
        public void Run()
        {
            //"{CommandName} {CommandArgs}"
            while (true)
            {
                string commandInput = this.reader.ReadLine();
                string result = this.commandInterpreter.Read(commandInput);

                this.writer.WriteLine(result);
            }

        }
    }
}
