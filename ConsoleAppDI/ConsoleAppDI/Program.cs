using System;
using DIDemo;
using DIDemo.NinjectModules;
using Ninject;
using Unity;
using DIDemo.UnityContainers;
using WarriorLibrary.MSEDI;

namespace ConsoleAppDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Weapon weapon;
            IWarrior warrior;
            string target;
            target = "target";

            //No injections
            weapon = new Sword();
            warrior = new Samurai(weapon); //Dependency Ninja gets sword
            
            Console.WriteLine("no inject:" + warrior.Attack(target));

            //Ninject
            IKernel kernel;
            kernel = new StandardKernel(new WarriorModule());
            
            warrior = kernel.Get<IWarrior>();
            
            Console.WriteLine("ninject:" + warrior.Attack(target));

            //Unity Container
            IUnityContainer unityContainer;
            unityContainer = new UnityContainer();
            UnityBootstrap.RegisterTypes(unityContainer);

            warrior = unityContainer.Resolve<Samurai>();

            Console.WriteLine("unity:" + warrior.Attack(target));

            //MS ServiceProvider
            WarriorService warriorService = new WarriorService();
            weapon = (Weapon)warriorService.ServiceProvider.GetService(typeof(IWeapon));
            Console.WriteLine(weapon.Name);

            warrior = (IWarrior)warriorService.ServiceProvider.GetService(typeof(Ninja));
            Console.WriteLine("ms service:" + warrior.Attack(target));
            
        }
    }
}
