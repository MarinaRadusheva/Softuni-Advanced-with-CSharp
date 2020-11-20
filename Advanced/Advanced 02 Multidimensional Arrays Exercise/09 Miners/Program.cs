using System;
using System.Linq;

namespace _09_Miners
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] directions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            char[,] field = ReadMatrix(size);
            int currentRow = 0;
            int currentCol = 0;
            int coal = 0;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (field[row,col]=='s')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                    if (field[row,col]=='c')
                    {
                        coal++;
                    }
                }
            }
            for (int i = 0; i < directions.Length; i++)
            {
                string command = directions[i];
                switch (command)
                {
                    case "up":
                        if (currentRow>0)
                        {
                            currentRow --;                           
                        }
                        break;
                    case "right":
                        if (currentCol<size-1)
                        {
                            currentCol ++;
                        }
                        break;
                    case "down":
                        if (currentRow<size-1)
                        {
                            currentRow ++;
                        }
                        break;
                    case "left":
                        if (currentCol>0)
                        {
                            currentCol--;
                        }
                        break;
                    default:
                        break;
                }
                if (field[currentRow,currentCol]=='c')
                {
                    coal--;
                    if (coal == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        return;
                    }
                    field[currentRow, currentCol] = '*';
                }
                else if (field[currentRow,currentCol]=='e')
                {
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    return;
                }
            }
            Console.WriteLine($"{coal} coals left. ({currentRow}, {currentCol})");
        }
        static char[,] ReadMatrix(int n)
        {
            char[,] matrix = new char[n,n];
            for (int row = 0; row < n; row++)
            {
                char[] rowElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }
            return matrix;
        }
    }
}
