using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDogEvents.Models
{
    public class DogPound
    {

        public List<Dog> Dogs;

        public int FoodAmount { get; set; }

        public DogPound()
        {
            Dogs = new List<Dog>() { new Dog(), new Dog("milo") };
            this.FoodAmount = 100;
        }

        public void AddDog(Dog d)
        {
            Dogs.Add(d);
            d.OnFeed += D_OnFeed;
        }

        public void RemoveDog(Dog d)
        {
            Dogs.Remove(d);
            d.OnFeed -= D_OnFeed;
        }

        private void D_OnFeed(object? sender, EventArgs e)
        {
            if (sender is Dog)
            {
                Dog d = (Dog)sender;
                this.FoodAmount -= d.EatAmount;
            }
        }

        public void FeedAllDogs()
        {
            foreach (var d in Dogs)
            {
                d.Feed();
            }
        }
    }
}
