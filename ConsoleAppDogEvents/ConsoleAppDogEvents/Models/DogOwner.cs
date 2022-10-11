using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDogEvents.Models
{
    public class DogOwner : Person
    {
        Dog dog;

        protected int dogBarkCount;
        const int scoldDogAfterBarks = 10;

        public DogOwner(Dog d)
        {
            dog = d;
            d.BarkCompleted += D_BarkCompleted;
         }

        private void D_BarkCompleted()
        {
            throw new NotImplementedException();
        }

        public void CheckScoldDog()
        {
            if(this.dogBarkCount % scoldDogAfterBarks == 0)
            {
                Console.WriteLine($"be queit {this.dog.Name}");
            }
            
        }
    }
}
