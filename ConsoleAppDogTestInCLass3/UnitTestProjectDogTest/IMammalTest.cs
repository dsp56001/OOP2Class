using Microsoft.VisualStudio.TestTools.UnitTesting;
using DogLibrary;

namespace UnitTestProjectDogTest
{

    [TestClass]
    public class IMammalTests
    {

        IMammal dog;

        public IMammalTests()
        {
            dog = new Dog();
        }


        [TestMethod]
        public void IMammalConstructor_DefaultValues()
        {
            //Arrange 
            IMammal d = new Dog();

            //Act

            //Assert
            Assert.IsNotNull(d);
            Assert.AreEqual(d.Name, "fido");
            Assert.AreEqual(d.Weight, 2);
            Assert.AreEqual(d.Age, 1);
            Assert.AreEqual(d.Sound, "woof!");
        }

        [TestMethod]
        public void IMammalConstructor_WithValues()
        {
            //Arrange 
            string DFullName = "DFullName";
            string DFullNameArf = "DFullNameArf";
            string DName = "DName";
            string DNameArf = "DNameArf";
            Dog dFull = new Dog(DFullName, 99, 98, DFullNameArf);
            Dog dName = new Dog(DName, 97, 96, DNameArf);

            //Act
            Assert.IsNotNull(dFull);

            //Assert
            Assert.AreEqual(dFull.Name, DFullName);
            Assert.AreEqual(dFull.Weight, 98);
            Assert.AreEqual(dFull.Age, 99);
            Assert.AreEqual(dFull.BarkSound, DFullNameArf);

            Assert.AreEqual(dName.Name, DName);
            Assert.AreEqual(dName.Weight, 96);
            Assert.AreEqual(dName.Age, 97);
            Assert.AreEqual(dName.BarkSound, DNameArf);
        }

        [TestMethod]
        public void IMammalMakeSoundSingle()
        {
            //arrange
            string IMammalSound;
            

            string makeSound;
            //act
            IMammalSound = dog.Sound;
            
            makeSound = dog.MakeSound();
            //assert
            
            Assert.AreEqual(IMammalSound, makeSound);
            Assert.AreNotEqual(IMammalSound, string.Empty);
        }
    }
}
