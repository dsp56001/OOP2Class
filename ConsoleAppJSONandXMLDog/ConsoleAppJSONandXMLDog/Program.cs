using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleAppJSONandXMLDog
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setup Dogs
            Dog fido = new Dog() { Age = 1, Name = "Fido" };
            Dog milo = new Dog() { Age = 1, Name = "Milo" };
            DogPound dogs = new DogPound() { Dogs = new Dog[] { fido, milo } };

            string json, xml;

            //convert to JSON using Newtonsoft
            json = JsonConvert.SerializeObject(fido, Formatting.Indented);


            //convert XML using XmlSerializer
            XmlSerializer serializer =
             new XmlSerializer(typeof(Dog)); //Does serailization based on type
            var memoryStream = new MemoryStream(); //could use TextWriter this is jsut a memory stream
            var streamWriter = new StreamWriter(memoryStream, System.Text.Encoding.UTF8);

            serializer.Serialize(streamWriter, fido);
            byte[] utf8EncodedXml = memoryStream.ToArray(); //encoded UTF8 Byte[]
            xml = System.Text.Encoding.UTF8.GetString(utf8EncodedXml); // back to string

            //Write values to console
            Console.WriteLine($"Dog json:\n{json}");
            Console.WriteLine($"Dog xml:\n{xml}");

            //Json convert back
            var jsonDog = JsonConvert.DeserializeObject<Dog>(json);
            //Check name need test harness
            Debug.Assert(
                jsonDog.Name.Equals(fido.Name),
                "Names don't Match");

            //XMS convert back
            memoryStream = new MemoryStream(utf8EncodedXml);
            var xmlDog = (Dog)serializer.Deserialize(memoryStream);
            //Check name need test harness
            Debug.Assert(
                xmlDog.Name.Equals(fido.Name),
                "Names don't Match");


            //Dogs
            string dogsJSON, dogsXML;

            dogsJSON = JsonConvert.SerializeObject(dogs, Formatting.Indented);
            dogsXML = XMLSerializer.XmlSerialize<DogPound>(dogs);


            //Write values to console
            Console.WriteLine($"Dogs json:\n{dogsJSON}");
            Console.WriteLine($"Dogs xml:\n{dogsXML}");

            Console.ReadLine();

        }
    }

    public static class XMLSerializer
    {
        public static T XmlDeserialize<T>(string toDeserialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (StringReader textReader = new StringReader(toDeserialize))
            {
                return (T)xmlSerializer.Deserialize(textReader);
            }
        }

        public static string XmlSerialize<T>(T toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }
    }
}
