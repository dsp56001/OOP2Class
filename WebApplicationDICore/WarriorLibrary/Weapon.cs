using System;
using System.Collections.Generic;
using System.Text;

namespace DIDemo
{
    public class Weapon : IWeapon
    {
        protected string name;
        public string Name { get => name; set => name = value; }

        public Weapon()
        {
            name = "Weapon";
        }

        public string Hit(string target)
        {
            return $"{this.Name} on {target}";
        }
    }
}
