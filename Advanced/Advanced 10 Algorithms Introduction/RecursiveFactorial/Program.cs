using System;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RecursiveFactirial(n));
        }

        public static long RecursiveFactirial(int n)
        {
            if (n<=1)
            {
                return 1;
            }
            return n * RecursiveFactirial(n - 1);
        }
    }
}
