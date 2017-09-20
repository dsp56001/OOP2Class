using System;
using System.Collections.Generic;
using System.Text;

namespace DogLibrary
{
    public class Cat : Mammal
    {
        public string MeowSound
        {
            get { return this.Sound; }
            set { this.Sound = value; }
        }
            

        public Cat()
        {

        }

        public string Meow()
        {
            return this.MakeSound();

        }

        public string Meow(int HowMany)
        {
            return this.MakeSound(HowMany);

        }

    }
}
