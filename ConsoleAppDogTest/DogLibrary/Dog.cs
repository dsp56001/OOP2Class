using System;
using System.Collections.Generic;
using System.Text;

namespace DogLibrary
{
    public class Dog
    {
        public int Age { get;  private set; }
        public int Weight { get; set; }
        public string Name { get; set; }
        public string BarkSound { get; set; }

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
            return this.BarkSound;
        }

        /// <summary>
        /// Barks the Dog more than once
        /// </summary>
        /// <param name="HowManyTimes">How many times to bak the dog</param>
        /// <returns></returns>
        public string Bark(int HowManyTimes)
        {
            string barkstring = string.Empty;
            for (int i = 0; i < HowManyTimes; i++)
            {
                barkstring += this.Bark() + " ";
            }
            return barkstring.Trim(); //trim cleans off any trailing spaces.
        }

        public void HappyBithday()
        {
            this.Age++;
        }

        public string About()
        {
            return string.Empty;
        }
    }
}
