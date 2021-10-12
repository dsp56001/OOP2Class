using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DogLibrary;

namespace WpfAppDogWRepo
{
    /// <summary>
    /// Interaction logic for WindowDog.xaml
    /// </summary>
    public partial class WindowDog : Window
    {
        Dog dog;

        public WindowDog() : this(new Dog())
        {
            
        }

        public WindowDog(Dog d)
        {
            InitializeComponent();
            this.dog = d;
            this.UpdateDogUI();
        }

        public void UpdateDogUI()
        {
            tbName.Text = dog.Name;
            tbAge.Text = dog.Age.ToString(); ;
            tbWeight.Text = dog.Weight.ToString();
        }
    }
}
