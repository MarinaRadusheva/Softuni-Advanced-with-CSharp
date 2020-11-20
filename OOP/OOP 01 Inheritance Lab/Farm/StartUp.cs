using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog rachael = new Dog();
            rachael.Eat();
            rachael.Bark();
            Puppy puppy = new Puppy();
            puppy.Weep();
            Cat bonny = new Cat();
            bonny.Meow();
        }
    }
}
