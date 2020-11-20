using System;

namespace _04_SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = ReadMatrix(n, n);
            char wantedChar = char.Parse(Console.ReadLine());
            bool charExists = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == wantedChar)
                    {
                        Console.WriteLine($"({row}, {col})");
                        charExists = true;
                        return;
                    }
                }
            }
            if (!charExists)
            {
                Console.WriteLine($"{wantedChar} does not occur in the matrix ");
            }
        }
       static char[,] ReadMatrix(int rows, int cols)
       {
           char[,] matrix = new char[rows, cols];
           for (int row = 0; row < rows; row++)
           {
               string input = Console.ReadLine();
               
               for (int i = 0; i < input.Length; i++)
               {
                   matrix[row, i] = input[i];
               }
               
           }
           return matrix;
       }
    }
}
