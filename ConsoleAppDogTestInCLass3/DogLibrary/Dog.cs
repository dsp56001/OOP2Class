using System;
using System.Collections.Generic;
using System.Text;

namespace DogLibrary
{
    public class Dog : Mammal
    {
        
        
        
        public string BarkSound
        {
            get
            {
                return this.Sound;
            }
            set
            {
                this.Sound = value;
            }
        }

        public static int DogCount; //Count of all dogs ever created

        public Dog() : this("fido", 1, 2, "woof!")
        {
            //nothing
        }

        public Dog(string Name) : this(Name, 1, 2, "woof!")
        {
            //nothing   
        }

        public Dog(string Name, int Age, int Weight, string BarkSound)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weight = Weight;
            this.BarkSound = BarkSound;
            DogCount++;
        }

        /// <summary>
        /// Make the dog bark
        /// </summary>
        /// <returns></returns>
        public string Bark()
        {
            return this.MakeSound();
        }

        /// <summary>
        /// Barks the Dog more than once
        /// </summary>
        /// <param name="HowManyTimes">How many times to bak the dog</param>
        /// <returns></returns>
        public string Bark(int HowManyTimes)
        {
            return base.MakeSound(HowManyTimes);
        }

        

        public string About()
        {
            return string.Empty;
        }
    }
}
