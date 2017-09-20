using Microsoft.VisualStudio.TestTools.UnitTesting;
using DogLibrary;

namespace UnitTestProjectDogTest
{


    [TestClass]
    public class DogTests
    {

        Dog dog;

        public DogTests()
        {
            dog = new Dog();
        }
    

        [TestMethod]
        public void DogConstructor_DefaultValues()
        {
            //Arrange 
            Dog d = dog;

            //Act

            //Assert
            Assert.IsNotNull(d);
            Assert.AreEqual(d.Name, "fido");
            Assert.AreEqual(d.Weight, 2);
            Assert.AreEqual(d.Age, 1);
            Assert.AreEqual(d.BarkSound, "woof!");
        }

        

        [TestMethod]
        public void DogCount()
        {
            //Arrange 
            int InitialDogCount = Dog.DogCount;

            //Act 
            Dog d = new Dog();
            int CountAfterAddingDog = Dog.DogCount;
            for (int i = 0; i < 10; i++)
            {
                d = new Dog();
            }
            int AfterTenMOreDogs = Dog.DogCount;
            //Assert
            Assert.AreEqual(InitialDogCount, CountAfterAddingDog - 1);
            Assert.AreEqual(InitialDogCount, AfterTenMOreDogs - 1 - 10);
        }

        [TestMethod]
        public void DogBarkSingle()
        {
            //arrange
            string barkSound;
            string afterBark;

            
            //act
            barkSound = dog.BarkSound;
            afterBark = dog.Bark();
           
            //assert
            Assert.AreEqual(barkSound, afterBark);
            
            Assert.AreNotEqual(afterBark, string.Empty);
        }

        [TestMethod]
        public void DogBarkMultiple()
        {
            //arrange
            dog = new Dog() { BarkSound = "nospace" };
            string barkSound;
            string afterBarks;
            int numBarks;
            string[] barks;
            //act
            numBarks = 5;
            barkSound = dog.BarkSound;
            afterBarks = dog.Bark(5);
            barks = afterBarks.Split(' ');
            //assert
            Assert.AreEqual(barks.Length, numBarks);
            Assert.AreNotEqual(afterBarks, string.Empty);
        }

        [TestMethod]
        public void DogAge()
        {
            //arrange

            //act

            //assert
        }
    }
}
