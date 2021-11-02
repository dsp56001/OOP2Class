using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppDogSave;

namespace UnitTestProjectDogSave
{
    
    [TestClass]
    public class UnitTestDogXML
    {
        [TestMethod]
        public void TestDogRepoGetXML()
        {
            //Arrange
            DogRepo repo = new DogRepo();
            List<Dog> dogs = repo.Dogs;
            string defaultXML = XMLSerializer.XmlSerialize<List<Dog>>(dogs);
            string repoXML;

            //Act
            repoXML = repo.GetXML();
            //Assert
            Assert.AreEqual(defaultXML, repoXML);
        }
    }
}
