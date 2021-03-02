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
                throw new Exception();
            }

            set
            {
                //Set sound 
                this.Sound = value;
            }
        }

        public static int DogCount; //Count of all dogs ever created


        public Dog() : this("fido", 1, 2, "woof")
        {

        }

        public Dog(string Name, int Age, int Weight, string BarkSound)
        {
            
        }

        

        /// <summary>
        /// Make the dog bark
        /// </summary>
        /// <returns></returns>
        public string Bark()
        {
            return string.Empty;
        }

        /// <summary>
        /// Barks the Dog more than once
        /// </summary>
        /// <param name="HowManyTimes">How many times to bak the dog</param>
        /// <returns></returns>
        public string Bark(int HowManyTimes)
        {
            return this.BarkSound;
        }

        

        public string About()
        {
            return string.Empty;
        }
    }
}
