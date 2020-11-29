
using System;

namespace CommandPattern.Models
{
    public class ExitCommand : Command
    {
        public override string Execute(string[] args)
        {
            Environment.Exit(0);
            return null;
        }
    }
}
