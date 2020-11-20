using System;
using System.Linq;

namespace _05_SquareWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = ReadMatrix(sizes[0], sizes[1]);
            int maxSum = int.MinValue;
            int maxR = 0;
            int maxC = 0;
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col + 1] + matrix[row + 1, col];
                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        maxR = row;
                        maxC = col;
                    }
                }
            }
            Console.WriteLine(matrix[maxR, maxC]+" "+ matrix[maxR, maxC + 1]);
            Console.WriteLine(matrix[maxR + 1, maxC]+" "+ matrix[maxR + 1, maxC + 1]);
            Console.WriteLine(maxSum);
        }
        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] rowElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }
            return matrix;
        }
    }
}
