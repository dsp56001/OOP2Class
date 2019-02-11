using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDogTestSimple
{
    public class Dog 
    {
        public int Age { get; protected set; }

        public int Weight { get; set; }

        public string Name { get; protected set; }

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
            string soundString = string.Empty;
            for (int i = 0; i < HowManyTimes; i++)
            {
                soundString += this.Bark() + " ";
            }
            return soundString.Trim(); //trim cleans off any trailing spaces.
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
