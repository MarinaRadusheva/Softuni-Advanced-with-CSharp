using System;
using System.Linq;

namespace ListyIteratorProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            ListyIterator<string> iterator = null;
            while ((command=Console.ReadLine())!="END")
            {
                try
                {
                    if (command.StartsWith("Create"))
                    {
                        string[] array = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();
                        //Create Stefcho Goshky
                        iterator = new ListyIterator<string>(array);
                    }
                    else
                    {
                        switch (command)
                        {
                            case "Move":
                                Console.WriteLine(iterator.Move());
                                break;
                            case "Print":
                                iterator.Print();
                                break;
                            case "HasNext":
                                Console.WriteLine(iterator.HasNext());
                                break;
                        }
                    }
                   
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
        }
    }
}
