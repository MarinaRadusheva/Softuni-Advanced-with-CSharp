
using CommandPattern.Core.Contracts;
using System;

namespace CommandPattern.Models
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
