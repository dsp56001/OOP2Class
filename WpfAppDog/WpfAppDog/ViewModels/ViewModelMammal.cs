using DogLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDog.Models;

namespace WpfAppDog.ViewModels
{
    class ViewModelMammal
    {

        private static ObservableCollection<WPFMammal> mammals;

        public ObservableCollection<WPFMammal> Mammals
        {
            get { return mammals; }
            set { mammals = value; }
        }

        public void LoadMammals()
        {
            if (mammals == null)
            {
                mammals = new ObservableCollection<WPFMammal>()
                {
                    new WPFMammal ( new Dog{ BarkSound="woof!", Name="fido"}),
                    new WPFMammal ( new Dog{ BarkSound="arf!", Name="rover"}),
                };
            }

            Mammals = mammals;
        }
    }
}
