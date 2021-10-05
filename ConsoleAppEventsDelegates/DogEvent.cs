using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;
using DogLibrary;

namespace ConsoleAppEventsDelegates
{
    public class DogEvent :   INotifyPropertyChanged
    {
        
        protected string name;
        protected string barkSound;

        public EventHandler BarkComplete;
        public delegate void Barked();  // delegate

        public event Barked BarkCompleted; // event

        public DogEvent()
        {
            
        }

        protected virtual void OnBarked(EventArgs e)
        {
            BarkComplete?.Invoke(this, e);
            BarkCompleted.Invoke();
        }

        public virtual string Bark()
        {
            BarkComplete?.Invoke(this, EventArgs.Empty);
            return this.BarkSound;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (Name != value)
                {
                    name = value;
                    RaisePropertyChanged("Name");

                }
            }
        }

        public string BarkSound
        {
            get
            {
                return barkSound;
            }
            set
            {
                if (BarkSound != value)
                {
                    barkSound = value;
                    RaisePropertyChanged("BarkSound");

                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }

    class DogEventArgs : EventArgs
    {
        public int NumBarks { get; set; }
        public DateTime CompletionTime { get; set; }
    }

}
