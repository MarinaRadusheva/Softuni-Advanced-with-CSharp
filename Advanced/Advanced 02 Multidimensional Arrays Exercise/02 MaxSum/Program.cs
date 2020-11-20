using System;
using System.Linq;

namespace _02_MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = ReadMatrix(sizes[0], sizes[1]);
            int maxSum = int.MinValue;
            int maxR = 0;
            int maxC = 0;
            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        maxR = row;
                        maxC = col;
                    }
                }
            }
            Console.WriteLine("Sum = "+maxSum);
            for (int r = maxR; r <= maxR+2; r++)
            {
                for (int c = maxC; c <= maxC+2; c++)
                {
                    Console.Write(matrix[r,c]+" ");
                }
                Console.WriteLine();

            }
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] rowElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }
            return matrix;
        }

    }
}
