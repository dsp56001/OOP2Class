using ConsoleAppDogEvents.Models;

namespace ConsoleAppDogEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Dog d = new Dog();
            d.Feed();

            DogOwner jeff = new DogOwner(d) { Name = "jeff" };
            for (int i = 0; i < 20; i++)
            {
                d.Bark();
            }
        }
    }
}