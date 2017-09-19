using Microsoft.VisualStudio.TestTools.UnitTesting;
using DogLibrary;

namespace UnitTestMammal
{
    [TestClass]
    class CatTests
    {
        Cat TestCat;

        public CatTests()
        {
            TestCat = new Cat();
        }

        [TestMethod]
        public void CatAge()
        {
            //arrange
            int age = TestCat.Age;


            //act
            TestCat.HappyBithday();
            int AgePlusOne = age + 1;

            //assert
            Assert.AreEqual(age + 1, AgePlusOne);
        }

        [TestMethod]
        public void MeowSingle()
        {
            //arrange
            string meowNoSpaces = "meowNOSpaces";
            string testMeow = string.Emptymeow;
            Cat cTestBark = new Cat() { MeowSound = meowNoSpaces };
            //act
            testMeow = dTestBark.Meow();

            //assert
            Assert.AreEqual(testMeow, meowNoSpaces);
        }

        [TestMethod]
        public void MeowBarkMultiple()
        {
            //arrange
            string meowNoSpaces = "meowNOSpaces";
            string testMeow = string.Emptymeow;
            int meowtimes = 3;  //shouldn't matter how many times it barks
            Dog dTestBark = new Dog() { BarkSound = meowNoSpaces };
            string[] meowAry;
            //act
            testMeow = dTestBark.Meow(meowtimes);
            testMeow = testMeow.Split(' ');

            //assert
            Assert.AreEqual(testMeow.Length, barkmeowtimestimes);
        }


    }

    
}
