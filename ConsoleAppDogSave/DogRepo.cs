using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDogSave
{
    [Serializable]
    public class DogRepo
    {
         
        public List<Dog> Dogs { get; set; }

        public DogRepo()
        {
            LoadDogs();
        }

        public void LoadDogs()
        {
            if (Dogs == null)
            {
                Dogs = new List<Dog>()
                {
                    new Dog () { Name="fido1", BarkSound="woof!" },
                    new Dog (){ Name="rover", BarkSound="arf!"},
                };
            }
        }
    }
}
