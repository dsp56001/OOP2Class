﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DIDemo
{
    public interface IWarrior
    {
        IWeapon Weapon { get; }
        string Attack(string target);
    }
    public abstract class Warrior : IWarrior
    {
        protected IWeapon weapon { get; set; }

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
