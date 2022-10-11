using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDogEvents.Models
{


    public class Dog
    {
        public string Name { get; set; }
        public string BarkSound { get; set; }
        protected int barkCount;

        public int Age { get; set; }

        public int Weight { get; set; }

        public event EventHandler OnFeed;
         
        public delegate void Barked();     // delegate
        public EventHandler? BarkComplete;  // enent handler
        public event Barked? BarkCompleted; // event


        protected int eatAmount;
        public int EatAmount { get => eatAmount; set => eatAmount = value; }

        public Dog() : this("fido") { }

        public Dog(string name)
        {
            this.Name = name;
            this.Age = 2;
            this.BarkSound = "woof!";
            this.OnFeed += onFeed;
            this.Weight = 10;
            
        }

        protected void onFeed(object? sender, EventArgs e)
        {
            this.Weight = Weight + this.EatAmount;
        }

        public void Feed()
        {
            //Invoke onFeed Handler
            this.OnFeed.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnBarked(EventArgs e)
        {
            BarkComplete?.Invoke(this, e);
            BarkCompleted?.Invoke();
        }

        public virtual string Bark()
        {
            BarkComplete?.Invoke(this, EventArgs.Empty);
            BarkCompleted?.Invoke();
            return this.BarkSound;
        }
    }

    public class BarkEventArgs : EventArgs
    {
        public string BarkSound { get; protected set; }

        public BarkEventArgs(string barkSound)
        {
            this.BarkSound = barkSound;
        }
    }
}
