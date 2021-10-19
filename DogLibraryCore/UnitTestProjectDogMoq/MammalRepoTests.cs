using DogLibrary;
using DogLibraryCore.Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProjectDogMoq
{
    [TestClass]
    class MammalRepoTests
    {

        [TestClass]
        public class MammalSimpleRepoTest
        {
            [TestMethod]
            public void TestFindByName()
            {
                //Arrange
                string findName = "fido";
                int findWeight = 20;
                Dog foundByName, foundByWeight;

                MammalRepo repo = new MammalRepo();
                repo.Add(new Dog() { Name = findName, Weight = 10 });
                repo.Add(new Dog() { Name = "milo", Weight = findWeight });
                //act
                foundByName = repo.GetMammalByName(findName) as Dog;
                foundByWeight = repo.GetMammalByWeight(findWeight) as Dog;

                //assert
                Assert.AreEqual(findName, foundByName.Name);
                Assert.AreEqual(findWeight, foundByWeight.Weight);
            }

            [TestMethod]
            public void TestFindByNameReturnsNullIfNotFound()
            {
                //Arrange
                string findName = "jeff";
                int findWeight = 20;
                Dog foundByName;

                MammalRepo repo = new MammalRepo();
                repo.Add(new Dog() { Name = "fido", Weight = 10 });
                repo.Add(new Dog() { Name = "milo", Weight = findWeight });
                //act
                foundByName = repo.GetMammalByName(findName) as Dog;


                //assert
                Assert.IsNull(foundByName);

            }

            [TestMethod]
            public void TestFindByWeightReturnsNullIfNotFound()
            {
                //Arrange

                int findWeight = 22;
                Dog foundByWeight;

                MammalRepo repo = new MammalRepo();
                repo.Add(new Dog() { Name = "fido", Weight = 10 });
                repo.Add(new Dog() { Name = "milo", Weight = 20 });
                //act
                foundByWeight = repo.GetMammalByWeight(findWeight) as Dog;


                //assert
                Assert.IsNull(foundByWeight);

            }
        }

    }
}
