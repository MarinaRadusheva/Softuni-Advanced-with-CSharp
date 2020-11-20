using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Wizard wizard = new DarkWizard("Manfred", 7);
            Console.WriteLine(wizard);
        }
    }
}
