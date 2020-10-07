using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalTests
{
    using AnimalShelter;
    [TestClass]
    public class DogTests
    {
        //This method tests wheter you can create a dog without a last walk.
        [TestMethod]
        public void CreateDogNoWalk()
        {
            SimpleDate birth = new SimpleDate(06, 05, 2020);
            SimpleDate expected = null;

            Dog dog = new Dog(2455, birth, "Hans", expected);

            Assert.AreEqual(dog.LastWalkDate, expected);
        }
        //This method tests wheter you can create a dog with a last walk.
        [TestMethod]
        public void CreateDogWalk()
        {
            SimpleDate birth = new SimpleDate(03, 05, 2020);
            SimpleDate expected = new SimpleDate(05, 05, 2020);

            Dog dog = new Dog(2543, birth, "Carl", expected);

            Assert.AreEqual(dog.LastWalkDate, expected);
        }
    }
}
