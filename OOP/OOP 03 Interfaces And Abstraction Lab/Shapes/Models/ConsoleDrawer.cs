using System;
using Shapes.Contracts;
namespace Shapes.Models
{
    public class ConsoleDrawer : IDrawer
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
