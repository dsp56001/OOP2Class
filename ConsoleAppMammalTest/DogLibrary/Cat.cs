using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogLibrary
{
    public class Cat : Mammal
    {
        public string MeowSound
        {
            get => default(string);
            set
            {
            }
        }

        public string Meow()
        {
            return this.MeowSound;
        }

        public string Meow(int HowManyTimes)
        {
            return this.MeowSound;
        }

    }
}