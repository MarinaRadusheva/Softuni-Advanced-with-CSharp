using System;

namespace Restaurant
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Food fish = new Fish("bass", 6.50m);
            Console.WriteLine($"{fish.Name} -> {fish.Price}$ -> {fish.Grams}gr.");
            Dessert souffle = new Cake("souffle");
            Console.WriteLine($"{souffle.Name} -> {souffle.Price}$ -> {souffle.Grams}gr. -> {souffle.Calories}");
            Dessert garash = new Dessert("garash", 8.70m, 70, 280);
            Console.WriteLine($"{garash.Name} -> {garash.Price}$ -> {garash.Grams}gr. -> {garash.Calories}");
        }
    }
}
