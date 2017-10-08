using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplicationDog.Controllers;

namespace UnitTestDog
{
    [TestClass]
    public class UnitTestHelloController
    {
        HelloController controller;

        public UnitTestHelloController()
        {
            this.controller = new HelloController();


        }

        [TestMethod]
        public void IndexTests()
        {
            //Arrange
            string Result = string.Empty;
            string ReseultWithParam = string.Empty;
            string stringName = "Jeff";
            //Act
            Result = controller.Index("");
            ReseultWithParam = controller.Index(stringName);
            //Assert
            Assert.AreEqual("Hello MVC!", Result);
            Assert.AreEqual($"Hello {stringName}", ReseultWithParam);
        }
    }
}
