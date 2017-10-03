﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppDog.ViewModels;

namespace WpfAppDog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Dog_Button_Click(object sender, RoutedEventArgs e)
        {
            WpfDog dogWin = new WpfDog();
            dogWin.Show();
        }

        private void Dogs_Button_Click(object sender, RoutedEventArgs e)
        {
            WpfMammals mamWin = new WpfMammals();
            mamWin.Show();
        }
    }
}
