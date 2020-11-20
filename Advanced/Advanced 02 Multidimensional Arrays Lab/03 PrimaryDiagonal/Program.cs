using System;
using System.Linq;

namespace _03_PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(n, n);
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sum += matrix[row, row];
            }
            Console.WriteLine(sum);
        }
        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] rowElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }
            return matrix;
        }
    }
}
