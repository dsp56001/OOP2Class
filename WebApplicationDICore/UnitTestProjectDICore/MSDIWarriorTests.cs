using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using WebApplicationDICore.Models;
using WebApplicationDICore.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Microsoft.Extensions.DependencyInjection;
using DIDemo;
using Microsoft.Extensions.Configuration;
using WebApplicationDICore;

namespace UnitTestProjectDICore
{
    [TestClass]
    public class MSDIWarriorTests
    {
        IServiceCollection serviceCollection;

        [TestMethod]
        public void WarriorsControllerIndex()
        {
            // Arrange
            var mockConfig = new Mock<IConfiguration>(); //Mock the website config
            Startup su = new Startup(mockConfig.Object); //Get a web startup object
            IServiceCollection serviceCollection;
            serviceCollection = new ServiceCollection();

            su.ConfigureServices(serviceCollection);    //run the Startup Configure Services
            ServiceProvider _serviceProviderTester;           //get a _service provider to test    
            _serviceProviderTester = serviceCollection.BuildServiceProvider();

            var controller = new WarriorController(_serviceProviderTester.GetService<IWarrior>());

            // Act
            var result = (ViewResult)controller.Index();

            // Assert
            Assert.AreEqual(typeof(ViewResult), result.GetType());
            Assert.AreEqual("Warrior Home", result.ViewName);
        }


        [TestMethod]
        public void WarriorControllerIndexDI()
        {
            // Arrange
            
           
            // Act
            

            // Assert
            
        }
    }
}
