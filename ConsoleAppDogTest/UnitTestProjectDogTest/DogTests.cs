using Microsoft.VisualStudio.TestTools.UnitTesting;
using DogLibrary;

namespace UnitTestProjectDogTest
{
    [TestClass]
    public class DogTests
    {
        [TestMethod]
        public void DogConstructor_DefaultValues()
        {
            //Arrange 
            Dog d = new Dog();
            Assert.IsNotNull(d);

            //Act


            //Assert
            Assert.AreEqual(d.Name , "fido");
            Assert.AreEqual(d.Weight, 2);
            Assert.AreEqual(d.Age, 1);
            Assert.AreEqual(d.BarkSound, "woof!");
        }

        [TestMethod]
        public void DogConstructor_WithValues()
        {
            //Arrange 
            Dog dFull = new Dog("DFullName", 99, 98, "DFullNameArf");
            Dog dName = new Dog("DName", 97, 96, "DNameArf");
            Assert.IsNotNull(dFull);

            //Act


            //Assert
            Assert.AreEqual(dFull.Name, "DFullName");
            Assert.AreEqual(dFull.Weight, 98);
            Assert.AreEqual(dFull.Age, 99);
            Assert.AreEqual(dFull.BarkSound, "DFullNameArf");

            Assert.AreEqual(dName.Name, "DName");
            Assert.AreEqual(dName.Weight, 96);
            Assert.AreEqual(dName.Age, 97);
            Assert.AreEqual(dName.BarkSound, "DNameArf");
        }
    }
}
