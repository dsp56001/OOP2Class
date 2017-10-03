using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfAppNotepad;

namespace UnitTestWPfNotePad
{
    [TestClass]
    public class MainWindowsTests
    {

        MainWindow window;

        [TestMethod]
        public void TestMethod1()
        {
            //Arrange

            //Act

            //Assert

        }

        [TestMethod]
        public void MainWindowCommands()
        {
            //Arrange
            window = new MainWindow();

            //Act
            
            //Assert
            //Assert.IsTrue(window.)
            //Dammit build in commands aren't testable need command pattern

        }
    }
}
