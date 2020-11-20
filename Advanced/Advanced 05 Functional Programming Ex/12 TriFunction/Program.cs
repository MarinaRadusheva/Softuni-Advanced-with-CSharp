using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _12_TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Func<string, int, bool> checkLength = (name, len) => name.Select(c => (int)c).Sum() >= len;
            //{
            //    int sum = 0;
            //    for (int i = 0; i < x.Length; i++)
            //    {
            //        sum += x[i];
            //    }
            //    return sum >= n;
            //};
            Action<string[], Func<string, int, bool>> TraverseAndPrint = (names, y) => Console.WriteLine($"{names.FirstOrDefault(p => y(p, n))}");
             //{
             //    foreach (var item in x)
             //    {
             //        if (y(item, n))
             //        { Console.WriteLine(item);
             //            break;
             //        }
             //    }
             //};
            TraverseAndPrint(names, checkLength);
        }
    }
}
