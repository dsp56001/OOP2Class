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
    public static class BinarySerializer
    {
        public static void Serialize(string Path, ISerializable o)
        {
            
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Path,
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, o);
            stream.Close();
        }

        public static T Deserialize<T>(string Path)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Path,
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read);
            var o = (T)formatter.Deserialize(stream);
            stream.Close();
            return o;
        }


    }
}
