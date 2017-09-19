using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogLibrary
{
    public abstract class Mammal : IMammal
    {


        public int Age
        {
            get;
            protected set;
            
        }

        public string Sound
        {
            get;
            protected set;
            
        }

        public string Name
        {
            get;
            protected set;
            
        }

        public int Weight
        {
            get;
            protected set;
            
        }

        public Mammal() : this("Mammal") { }
        public Mammal(string Name) : this(Name, 1,2, "sound") { }
        public Mammal (string Name, int Age, int Weight, string Sound)
        {
            this.Age = Age;
            this.Weight = Weight;
            this.Sound = Sound;
            this.Name = Name;
        }
        
        

        public void MakeSound()
        {
            throw new System.NotImplementedException();
        }

        public virtual void HappyBirthday()
        {
            this.Age++;
        }
    }
}