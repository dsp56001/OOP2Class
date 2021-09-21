using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDICore.Models
{
    public class DogRepo
    {
        public List<Dog> Dogs { get; set; }

        public DogRepo()
        {
            Dogs ??= new List<Dog>()
            {
                new Dog(),
                new Dog() { Name="milo", Age=2},
                new Dog() { Name="roover", Age=3}
            };
        }

        public void AddDog(Dog d)
        {
            this.Dogs.Add(d);
        }
    }
}
