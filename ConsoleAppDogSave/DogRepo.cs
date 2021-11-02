using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

        public string GetXML()
        {
            XmlSerializer serializer = new XmlSerializer(Dogs.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                serializer.Serialize(textWriter, Dogs);
                return textWriter.ToString();
            }
        }

        public void LoadFromXML(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(Dogs.GetType());
            using (StringReader textReader = new StringReader(xml))
            {
                this.Dogs = (List<Dog>)serializer.Deserialize(textReader);
            }
        }
    }
}
