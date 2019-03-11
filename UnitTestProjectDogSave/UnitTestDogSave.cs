using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppDogSave;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace UnitTestProjectDogSave
{
    [TestClass]
    public class UnitTestDogSave
    {

        WindowsDogRepo repo;

        Dog d;
        string Path;

        public UnitTestDogSave()
        {
            repo = new WindowsDogRepo();
            d = new Dog();
            Path = "testDog2.bin";
        }

        [TestMethod]
        public void TestDog_Save()
        {
            //Arrange
            IFormatter formatter = new BinaryFormatter();
            Stream wStream, rStream;

            Dog deserailizedDog;
            //Act
            using (wStream = new FileStream(Path,
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(wStream, d);
            }
            
            using (rStream = new FileStream(Path,
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read))
            {

                deserailizedDog = (Dog)formatter.Deserialize(rStream);
            }
            //Assert
            Assert.AreEqual(deserailizedDog, d);
            


        }

        [TestCleanup]
        public void CleanupTest()
        {
            System.IO.File.Delete(Path);
        }

        [TestMethod]
        public void TestDogCollectionSaving_DefaultPath()
        {
            //Arrange
            string realPath;
            string defaultPath; 

            //Act
            defaultPath = "MyFile.bin";
            realPath = repo.Path;

            //Assert
            Assert.AreEqual(defaultPath, realPath);
        }

        [TestMethod]
        public void TestDogCollectionSaving_Load()
        {
            //Arrange
            List<Dog> loadedDogs;

            //Act
            repo.Save();
            loadedDogs = (List<Dog>)repo.Load();

            //Assert
            Assert.AreEqual(repo.Dogs.Count, loadedDogs.Count);
            for(int i = 0; i<repo.Dogs.Count; i++)
            {
                // Assert.AreEqual(repo.Dogs[i], loadedDogs[i]);  fail as dogs aren't 
                CollectionAssert.AreEqual(repo.Dogs, loadedDogs);
            }
        }
    }
}
