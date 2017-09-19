using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DogLibrary;

namespace UnitTestMammal
{
    [TestClass]
    public class MammalTest
    {
        [TestMethod]
        [ExpectedException(typeof(MissingMethodException), "Cannot create an abstract class.")] //Since it's abstact it doesn't have constructor it will throw a MissingMethodException 
        public void MammalIsAbstract_Throws()
        {
            var ae = Activator.CreateInstance<Mammal>(); //Will throw an exception
        }
    }
}
