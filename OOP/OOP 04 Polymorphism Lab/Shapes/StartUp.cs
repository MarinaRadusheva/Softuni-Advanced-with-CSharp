using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(5, 9);
            Shape circle = new Circle(8);
            Console.WriteLine(circle.Draw());
            Console.WriteLine( rectangle.Draw());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(circle.CalculateArea());
        }
    }
}
