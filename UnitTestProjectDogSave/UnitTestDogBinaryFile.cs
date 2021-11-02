using ConsoleAppDogSave;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace UnitTestProjectDogSave
{
    [TestClass]
    public class UnitTestDogBinaryFile
    {

        Dog d;
        string Path;

        public UnitTestDogBinaryFile()
        {

            d = new Dog();

            Path = "testDog3.bin";
        }

        

        [TestMethod]
        public void TestDog_Save()
        {
            //Arrange
            Dog deserailizedDog;
            Stream rStream;
            //Act 
            
            //save dog
            BinarySerializer.Serialize(Path, d);
            IFormatter formatter = new BinaryFormatter();

            using (rStream = new FileStream(Path,
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read))
            {

                deserailizedDog = (Dog)formatter.Deserialize(rStream);
            }
            //Asset
            Assert.AreEqual(deserailizedDog, d);
        }

        [TestCleanup]
        public void CleanupTest()
        {
            System.IO.File.Delete(Path);
        }
    }
}
