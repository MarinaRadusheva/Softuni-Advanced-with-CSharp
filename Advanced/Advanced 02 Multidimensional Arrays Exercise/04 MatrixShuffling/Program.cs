using System;
using System.Linq;

namespace _04_MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix= ReadMatrix(sizes[0], sizes[1]);
            string input = "";
            while ((input=Console.ReadLine())!="END")
            {
                string[] command = input.Split();
                if (command.Length!=5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                if (command[0]!="swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int row1 = int.Parse(command[1]);
                int col1 = int.Parse(command[2]);
                int row2 = int.Parse(command[3]);
                int col2 = int.Parse(command[4]);
                if (row1<0||row1>sizes[0]||col1<0||col1>sizes[1]||row2<0||row2>sizes[0]||col2<0||col2>sizes[1])
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    string temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;
                }

                PrintMatrix(matrix);
            }

        }
        static string[,] ReadMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] rowElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }
            return matrix;
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
