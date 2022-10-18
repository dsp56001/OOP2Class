using DogLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAppDog.Models;
using WpfAppDog.ViewModels;

namespace WpfAppDog
{
    /// <summary>
    /// Interaction logic for WpfDog.xaml
    /// </summary>
    public partial class WpfMammal : Window
    {
        public WpfMammal()
        {
            InitializeComponent();
        }

        private void MammalViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModelMammals viewControl = new WpfAppDog.ViewModels.ViewModelMammals();
            viewControl.LoadMammals();


            this.DataContext = viewControl.Mammals[0];
            MammalView1.DataContext = viewControl.Mammals[0];


        }

        
    }
}
