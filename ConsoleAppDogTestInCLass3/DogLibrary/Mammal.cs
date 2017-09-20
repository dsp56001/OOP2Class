using System;
using System.Collections.Generic;
using System.Text;

namespace DogLibrary
{
    public abstract class Mammal : IMammal
    {
        

        public int Age { get; protected set; }

        public int Weight { get; set; }

        public string Name { get; protected set; }

        public string Sound { get; set; }

        public Mammal() : this("Mammal Name", 1, 2, "Mammal Sound") { }

        public Mammal(string Name, int Age, int Weight, string Sound)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weight = Weight;
            this.Sound = Sound;
        }

        public string MakeSound()
        {
            return this.Sound;
        }

        public string MakeSound(int HowManyTimes)
        {
            string soundString = string.Empty;
            for (int i = 0; i < HowManyTimes; i++)
            {
                soundString += this.MakeSound() + " ";
            }
            return soundString.Trim(); //trim cleans off any trailing spaces.
        }

        public void HappyBithday()
        {
            this.Age++;
        }
    }
}
