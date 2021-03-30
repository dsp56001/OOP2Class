using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Injection;

namespace DIDemo.UnityContainers
{
    public static class UnityBootstrap
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IWarrior, Samurai>();
            container.RegisterType<Warrior, Samurai>();
            //Will inject a sword whenever an IWeapon is needed
            container.RegisterType<IWeapon, Sword>();
            //Will inject Katana into Samurai
            container.RegisterType<Samurai>(new InjectionConstructor(new Katana()));
            //Will inject Sword into Ninja
            container.RegisterType<Ninja>(new InjectionConstructor(new Sword()));
        }
    }
}
