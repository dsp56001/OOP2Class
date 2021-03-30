using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIDemo.NinjectModules
{
    public class WarriorModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IWarrior>().To<Samurai>();
            this.Bind<Warrior>().To<Samurai>();
            //Will inject Sword into IWeapon 
            this.Bind<IWeapon>().To<Sword>(); 
            //Will inject Katana into Samurai
            this.Bind<IWeapon>().To<Katana>().WhenInjectedInto<Samurai>();
            //Will inject Sword into Ninja
            this.Bind<IWeapon>().To<Sword>().WhenInjectedInto<Ninja>();
        }
    }
}
