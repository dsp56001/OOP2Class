using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfAppDog.Models;
using DogLibrary;
using System.Collections.Generic;
using System.ComponentModel;

namespace UnitTestWpfDog
{
    [TestClass]
    public class WPFMammalTest
    {
        WPFMammal wpfMammal;

        public WPFMammalTest()
        {
            wpfMammal = new WPFMammal(new Dog());
        }

        [TestMethod]
        public void TestHappyBirthDay()
        {
            //Arrange
            int Age = wpfMammal.Age;
            int AgeAfterHappyBirthday = 0;
            List<string> receivedEvents = new List<string>();

            wpfMammal.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
            {
                receivedEvents.Add(e.PropertyName);
            };

            //Act
            wpfMammal.HappyBirthday.Execute(null);
            AgeAfterHappyBirthday = wpfMammal.Age;
            //Assert
            Assert.AreEqual(Age + 1, AgeAfterHappyBirthday);
            Assert.AreEqual(receivedEvents[0], "Age");
        }

        [TestMethod]
        public void TestDependencyProperties()
        {
            //Arrange


            //Act 
            wpfMammal.Name = "test";


            //Assert
        }
    }
}
