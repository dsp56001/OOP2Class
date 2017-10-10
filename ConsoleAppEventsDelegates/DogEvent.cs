using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;

namespace ConsoleAppEventsDelegates
{
    public class DogEvent :  INotifyPropertyChanged
    {
        
        protected string name;
        protected string barkSound;

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
}
