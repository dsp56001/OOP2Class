using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDICore.Models
{
    public class Dog : IDog
    {
        protected string name; 
        public string Name { get => this.name; set { this.name = value; } }

        protected int age;
        public int Age { get => this.age; set => this.age = value; }


        protected int id;
        public int DogID { get => this.id; set => this.id = value; }

        static int count;
        public Dog()
        {
            this.Name = "Fido";
            this.Age = 2;
            this.DogID = count;
            count++;
        }

        public string About()
        {
            return $"Hello my name is {this.Name}, I',m this {this.Age} years old.";
        }
    }
}
