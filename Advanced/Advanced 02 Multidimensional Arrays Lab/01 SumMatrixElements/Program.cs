using System;
using System.Linq;

namespace _01_SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = ReadMatrix(sizes[0], sizes[1]);
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }
            Console.WriteLine(sum);
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows,cols];
            for (int row = 0; row < rows; row++)
            {
                int[] rowElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col <cols; col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }
            return matrix;
        }
    }
}
