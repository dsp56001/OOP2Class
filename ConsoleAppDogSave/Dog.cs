using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDogSave
{
    /*
    [Serializable]
    public sealed class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string BarkSound { get; set; }
        
        /// <summary>
        /// Shows how to compare dog classes
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            var toCompareWith = other as Dog;
            if (toCompareWith == null)
                return false;
            return this.Name == toCompareWith.Name &&
                this.Age == toCompareWith.Age;
        }


        /// <summary>
        /// must overide this also
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
    */

    //custom
    
    [Serializable]
    public class Dog : ISerializable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string BarkSound { get; set; }

        public Dog()
        {
            this.BarkSound = "woof!";
            this.Age = 1;
        }


        /// <summary>
        /// Protected constuctor that can load a dog from a serialized stream
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected Dog(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            Age = info.GetInt32("Age");
            BarkSound = info.GetString("BarkSound");
        }

        /// <summary>
        /// Adds Data to Serializtion of Dog class
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public virtual void GetObjectData(SerializationInfo info,
            StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Age", Age);
            info.AddValue("BarkSound", BarkSound);

        }

        /// <summary>
        /// SHows how to compare dogs for equality
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            var toCompareWith = other as Dog;
            if (toCompareWith == null)
                return false;
            return this.Name == toCompareWith.Name &&
                this.Age == toCompareWith.Age;
        }


        /// <summary>
        /// Must overide this also
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
    
}
