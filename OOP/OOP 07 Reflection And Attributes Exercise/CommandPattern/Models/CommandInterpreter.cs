using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Models
{
    public class CommandInterpreter : ICommandInterpreter
    {

        public string Read(string args)
        {
            //"{CommandName} {CommandArgs}
            string[] inputElements = args.Split(" ");
            string commandName = inputElements[0];
            string[] commandArgs = inputElements.Skip(1).ToArray();
            //string commandTypeStr = commandName + "Command";
            var commandType = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name.StartsWith(commandName));
            string result = string.Empty;
            if (commandType!=null)
            {
                var commandInstance = (ICommand)Activator.CreateInstance(commandType);
                result = commandInstance.Execute(commandArgs);
            }
            else
            {
                throw new InvalidOperationException("Command has to be 'Hello' or 'Exit'");
            }
            return result;

        }
    }
}
