using System;
using System.Text;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAddress = Console.ReadLine().Split();
            string name = nameAddress[0] + " " + nameAddress[1];
            string street = nameAddress[2];
            StringBuilder city = new StringBuilder();
            for (int i = 3; i < nameAddress.Length; i++)
            {
                city.Append(nameAddress[i] + " ");
            }
            Threeuple<string, string, string> nameAdr = new Threeuple<string, string, string>(name, street, city.ToString());
            string[] nameLitres = Console.ReadLine().Split();
            bool isDrunk = false;
            if (nameLitres[2]=="drunk")
            {
                isDrunk = true;
            }
            Threeuple<string, int, bool> consumedBeer = new Threeuple<string, int, bool>(nameLitres[0], int.Parse(nameLitres[1]), isDrunk);
            string[] bankAccount = Console.ReadLine().Split();
            Threeuple<string, double, string> nameBank = new Threeuple<string, double, string>(bankAccount[0], double.Parse(bankAccount[1]), bankAccount[2]);
            Console.WriteLine(nameAdr);
            Console.WriteLine(consumedBeer);
            Console.WriteLine(nameBank);

        }
    }
}
