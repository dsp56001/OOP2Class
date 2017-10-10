﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppEventsDelegates;
using System.ComponentModel;
using System.Collections.Generic;

namespace UnitTestProjectDogEvent
{
    [TestClass]
    public class UnitTestDog
    {

        DogEvent dog;

        public UnitTestDog()
        {
            dog = new DogEvent();
        }


        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            List<string> receivedEvents = new List<string>();

            dog.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
            {
                receivedEvents.Add(e.PropertyName);
            };
            //Act
            dog.Name = "something";
            dog.BarkSound = "something";

            //Assert
            Assert.AreEqual("Name", receivedEvents[0]);
            Assert.AreEqual("BarkSound", receivedEvents[1]);
            Assert.IsInstanceOfType(dog.PropertyChanged , typeof(PropertyChangedEventHandler));
        }
    }
}