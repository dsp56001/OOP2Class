using Microsoft.VisualStudio.TestTools.UnitTesting;
using DogLibrary;

namespace UnitTestMammal
{
    [TestClass]
    public class CatTests
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
            TestCat.HappyBirthday();
            int AgePlusOne = age + 1;

            //assert
            Assert.AreEqual(age + 1, AgePlusOne);
        }

        [TestMethod]
        public void MeowSingle()
        {
            //arrange
            string meowNoSpaces = "meowNOSpaces";
            string testMeow = string.Empty;
            Cat cTestBark = new Cat() { MeowSound = meowNoSpaces };
            //act
            testMeow = cTestBark.Meow();

            //assert
            Assert.AreEqual(testMeow, meowNoSpaces);
        }

        [TestMethod]
        public void MeowBarkMultiple()
        {
            //arrange
            string meowNoSpaces = "meowNOSpaces";
            string testMeow = string.Empty;
            int meowtimes = 3;  //shouldn't matter how many times it barks
            Cat cTestMeow = new Cat() { MeowSound = meowNoSpaces };
            string[] meowAry;
            //act
            testMeow = cTestMeow.Meow(meowtimes);
            meowAry = testMeow.Split(' ');

            //assert
            Assert.AreEqual(testMeow.Length, meowtimes);
        }


    }

    
}
