using DogLibrary;
using DogLibraryCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestProjectDogMoq
{
    [TestClass]
    public class UnitDog
    {

        Dog d;
        FakeMammal f;

        public UnitDog()
        {
            d = new Dog();
            f = new FakeMammal();
        }
         
        
        [TestMethod]
        public void TestDogHappyBirthday()
        {
            //Arrange
            int age, ageAfter;

            //Act 
            age = d.Age;
             d.HappyBirthday();
            ageAfter = d.Age;

            //Assert
            Assert.AreEqual(age + 1, ageAfter);
        }

        [TestMethod]
        public void TestFakeMammalHappyBirthday()
        {
            //Arrange
            var mockMammal = new Mock<IMammal>();
            int age, ageAfter;

            //Act 
            mockMammal.Setup(m => m.Age).Returns(1);
            mockMammal.Setup(m => m.HappyBirthday()).Returns(2);

            age = mockMammal.Object.Age;
            ageAfter = mockMammal.Object.HappyBirthday();
           

            //Assert
            Assert.AreEqual(age + 1, ageAfter);
        }


        [TestMethod]
        public void TestMockMammalHappyBirthday()
        {
            //Arrange
            int age, ageAfter;

            //Act 
            age = f.Age;
            f.HappyBirthday();
            ageAfter = f.Age;

            //Assert
            Assert.AreEqual(age + 1, ageAfter);
        }

    }
}
