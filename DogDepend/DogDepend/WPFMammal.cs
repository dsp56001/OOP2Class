﻿using DogLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfAppDog.Models
{
    public class WPFMammal : DependencyObject, INotifyPropertyChanged
    {
        IMammal mammal;


        public ICommand HappyBirthday { get; set; }



        public WPFMammal(IMammal mammal)
        {
            this.mammal = mammal;
            this.HappyBirthday = new WPFMammalCommand(ExecuteCommandHappyBirthday, CanExecuteCommandHappyBirthday);
        }

        private bool CanExecuteCommandHappyBirthday(object parameter)
        {
            return true;
        }

        private void ExecuteCommandHappyBirthday(object parameter)
        {
            this.mammal.HappyBirthday();
            RaisePropertyChanged("Age");
        }



        public int Age
        {
            get
            {
                return mammal.Age;
            }



        }

        public string Name
        {
            get
            {
                return mammal.Name;
            }
            set
            {
                if (Name != value)
                {
                    mammal.Name = value;
                    //OLD way
                    //RaisePropertyChanged("Name");
                    //New way PropertyName is optional
                    RaisePropertyChanged();

                    //Also update About?
                    RaisePropertyChanged("About");

                }
            }
        }

        public int Weight
        {
            get
            {
                return mammal.Weight;
            }

        }

        public string  About
        {
            get { return mammal.About(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class WPFMammalCommand : ICommand
    {
        public delegate void ICommandOnExecute(object parameter);
        public delegate bool ICommandOnCanExecute(object parameter);

        private ICommandOnExecute _execute;
        private ICommandOnCanExecute _canExecute;

        public WPFMammalCommand(ICommandOnExecute onExecuteMethod, ICommandOnCanExecute onCanExecuteMethod)
        {
            _execute = onExecuteMethod;
            _canExecute = onCanExecuteMethod;
        }

        #region ICommand Members

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }

        #endregion
    }
}
