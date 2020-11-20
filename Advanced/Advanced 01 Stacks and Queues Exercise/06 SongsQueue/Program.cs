using System;
using System.Collections.Generic;

namespace _06_SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>(input);
            while (songs.Count!=0)
            {
                string commandText = Console.ReadLine();
                string[] command = commandText.Split();
                string action = command[0];
                switch (action)
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string songToAdd = commandText.Substring(4);
                        if(!songs.Contains(songToAdd))
                        {
                            songs.Enqueue(songToAdd);
                        }
                        else
                        {
                            Console.WriteLine($"{songToAdd} is already contained!");
                        }
                        
                        break;
                        case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine( "No more songs!");
        }
    }
}
