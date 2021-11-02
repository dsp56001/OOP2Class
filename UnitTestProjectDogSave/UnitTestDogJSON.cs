using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppDogSave;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace UnitTestProjectDogSave
{
    [TestClass]
    public class UnitTestDogJSON
    {
        [TestMethod]
        public void TestDogRepoGetXML()
        {
            //Arrange
            DogRepo repo = new DogRepo();
            List<Dog> dogs = repo.Dogs;
            string JSONSerialString = JSONSerializer.JsonSerialize(repo);
            string newtonsoftString;

            //Act
            newtonsoftString = JsonConvert.SerializeObject(repo);
            //Assert
            Assert.AreEqual(JSONSerialString, newtonsoftString);
        }
    }
}
