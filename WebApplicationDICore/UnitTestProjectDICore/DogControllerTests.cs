using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using WebApplicationDICore.Models;
using WebApplicationDICore.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationDICore;
using Microsoft.Extensions.Configuration;

namespace UnitTestProjectDICore
{
    [TestClass]
    public class DogControllerTests
    {

        [TestMethod]
        public void DogControllerIndex()
        {
            // Arrange
            IDog _dog = new Dog();
            var controller = new DogController(_dog); //no injection

            // Act
            var result = (ViewResult)controller.Index();

            // Assert
            Assert.AreEqual(typeof(ViewResult), result.GetType());
            Assert.AreEqual("Dog Home", result.ViewName);
        }

        [TestMethod]
        public void DogControllerIndexDI()
        {
            // Arrange
            IDog _dog = new Dog();
            var controller = new DogController(_dog);

            // Act
            var result = (ViewResult)controller.Index();

            // Assert
            Assert.AreEqual(typeof(ViewResult), result.GetType());
            Assert.AreEqual(_dog.GetType(), result.Model.GetType());
        }

        public void DogControllerDI()
        {
            // Arrange
            var mockConfig = new Mock<IConfiguration>(); //Mock the website config
            Startup su = new Startup(mockConfig.Object); //Get a web startup object
            IServiceCollection serviceCollection;        
            serviceCollection = new ServiceCollection();
            
            su.ConfigureServices(serviceCollection);    //run the Startup Configure Services
            ServiceProvider _serviceProviderTester;           //get a _service provider to test    
            _serviceProviderTester = serviceCollection.BuildServiceProvider();

            // Act
            var controller = new DogController(_serviceProviderTester.GetService<IDog>()); //no injection
            var result = (ViewResult)controller.Index();

            // Assert
            Assert.AreEqual(typeof(ViewResult), result.GetType());
            Assert.AreEqual("Dog Home", result.ViewName);
        }
    }
}
