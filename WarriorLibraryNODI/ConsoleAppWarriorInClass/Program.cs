using DIDemo;
using System;

namespace ConsoleAppWarriorInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IWeapon sword = new Sword();
            IWarrior Ninja = new Ninja(sword);
            Console.WriteLine(Ninja.Attack("whatever"));

        }
    }
}
