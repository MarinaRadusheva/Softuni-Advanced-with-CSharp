using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {


            try
            {
                string[] pizzaInput = Console.ReadLine().Split();
                Pizza pizza = new Pizza(pizzaInput[1]);

                string[] nextLine = Console.ReadLine().Split();
                while (nextLine[0] != "END")
                {
                    if (nextLine[0].ToLower() == "dough")
                    {
                        Dough dough = new Dough(nextLine[1], nextLine[2], double.Parse(nextLine[3]));
                        pizza.Dough = dough;
                    }
                    else
                    {
                        Topping topping = new Topping(nextLine[1], double.Parse(nextLine[2]));
                        pizza.AddTopping(topping);
                    }


                    nextLine = Console.ReadLine().Split();
                }
                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }


        }
    }
}