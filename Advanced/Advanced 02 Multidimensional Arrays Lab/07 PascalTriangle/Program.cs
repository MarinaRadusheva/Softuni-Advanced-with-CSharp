using System;

namespace _07_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[n][];
           
            pascalTriangle[0] = new long[] { 1};
            if (n==1)
            {
                Console.WriteLine(1);
                return;
            }
   
            for (int i = 1; i < n; i++)
            {
                long[] nextLine = new long[i + 1];
                nextLine[0] = 1;
                nextLine[nextLine.Length - 1] = 1;               
                for (int j = 1; j < nextLine.Length-1; j++)
                {
                    nextLine[j] = pascalTriangle[i - 1][j] + pascalTriangle[i - 1][j - 1];
                }
                pascalTriangle[i] = nextLine;
            }
            foreach (var row in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
