using NUnit.Framework;
using DogLibrary;

namespace NUnitTestProject
{
    public class DogTests
    {

        Dog TestDog;

        [SetUp]
        public void Setup()
        {
            TestDog = new Dog();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void DogConstructor_WithValues()
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
            Assert.That(dFull.Name, Is.EqualTo( DFullName));
            Assert.AreEqual(dFull.Weight, 98);
            Assert.AreEqual(dFull.Age, 99);
            Assert.AreEqual(dFull.BarkSound, DFullNameArf);

            Assert.AreEqual(dName.Name, DName);
            Assert.AreEqual(dName.Weight, 96);
            Assert.AreEqual(dName.Age, 97);
            Assert.AreEqual(dName.BarkSound, DNameArf);
        }

        [Test]
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
            Assert.That(InitialDogCount, Is.EqualTo(CountAfterAddingDog - 1));
            Assert.AreEqual(InitialDogCount, CountAfterAddingDog - 1);
            Assert.AreEqual(InitialDogCount, AfterTenMOreDogs - 1 - 10);
        }

        [Test]
        public void DogBarkSingle()
        {
            //arrange
            string barkNoSapces = "BarkNOSpaces";
            string testBark = string.Empty;
            Dog dTestBark = new Dog() { BarkSound = barkNoSapces };
            //act
            testBark = dTestBark.Bark();

            //assert
            Assert.AreEqual(testBark, barkNoSapces);
        }

        [Test]
        [TestCase(3)]
        public void DogBarkMultiple(int numBarks)
        {
            //arrange
            string barkNoSapces = "BarkNOSpaces";
            string testBark = string.Empty;
            int barktimes = numBarks;  //shouldn't matter how many times it barks
            Dog dTestBark = new Dog() { BarkSound = barkNoSapces };
            string[] barkAry;
            //act
            testBark = dTestBark.Bark(barktimes);
            barkAry = testBark.Split(barkNoSapces, System.StringSplitOptions.None);

            //assert
            Assert.AreEqual(barkAry.Length - 1, barktimes);
        }
    }
}