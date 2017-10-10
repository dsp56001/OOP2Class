using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppDogSave;
using System.Collections.Generic;

namespace UnitTestProjectDogSave
{
    [TestClass]
    public class UnitTestDogSave
    {

        WindowsDogRepo repo;

        public UnitTestDogSave()
        {
            repo = new WindowsDogRepo();
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
