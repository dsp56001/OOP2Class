using System;
using System.Collections.Generic;
using System.Text;

namespace NinjectDemo
{
    public abstract class Warrior
    {
        protected IWeapon weapon;

        public IWeapon Weapon => weapon;
        

        public Warrior(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public string Attack(string target)
        {
            return $"{this} uses {this.weapon.Hit(target)}";
        }
    }
}
