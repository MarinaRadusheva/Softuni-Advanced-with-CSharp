using System;
using System.Linq;

namespace _06_JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = ReadJaggedArray(n);
            string input = "";
            while ((input = Console.ReadLine())!="END")
            {
                string[] command = input.Split();
                int row = int.Parse(command[1]);               
                int col = int.Parse(command[2]);
                if (row > n - 1 || row<0 || jagged[row].Length-1<col||col<0)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                int value = int.Parse(command[3]);
                if (command[0]=="Add")
                {
                    jagged[row][col] += value;
                }
                else if (command[0]=="Subtract")
                {
                    jagged[row][col] -= value;
                }
                
            }
            PrintJagged(jagged);
        }

        static int[][] ReadJaggedArray(int n)
        {
            int[][] jagged = new int[n][];
            for (int row = 0; row < n; row++)
            { 
                jagged[row]= Console.ReadLine().Split().Select(int.Parse).ToArray();
                
            }
            return jagged;
        }
        static void PrintJagged(int[][] jagged)
        {
            for (int row = 0; row < jagged.GetLength(0); row++)
            {
                Console.WriteLine(string.Join(" ",jagged[row]));
            }
        }
    }
}
