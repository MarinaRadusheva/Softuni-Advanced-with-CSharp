using System;
using System.Linq;

namespace _01_DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(n, n);
            int primaryDiagonal = 0;
            for (int i = 0; i < n; i++)
            {
                primaryDiagonal += matrix[i, i];
            }
            int secondaryDiagonal = 0;
            for (int i = 0; i <n; i++)
            {
                secondaryDiagonal += matrix[i, n - i-1];
            }
            int diff = Math.Abs(primaryDiagonal - secondaryDiagonal);
            Console.WriteLine(diff);
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
