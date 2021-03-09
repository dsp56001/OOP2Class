using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDogSave
{
    public class WindowsDogRepo : DogRepo
    {

        public string Path { get; set; }

        public WindowsDogRepo()
        {
            Path = "MyFile.bin";
            
        }

        public bool Save()
        {
            if(Path==null)
            {
                return false;
            }
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(this.Path,
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Dogs);
            stream.Close();
            return true;
        }

        public ICollection<Dog> Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Path,
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read);
            List<Dog> dogs =  (List<Dog>)formatter.Deserialize(stream);
            stream.Close();
            return dogs;
        }
    }
}
