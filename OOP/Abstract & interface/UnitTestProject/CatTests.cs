using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalTests
{
    using AnimalShelter;
    [TestClass]
    public class CatTests
    {
        //This method tests wheter you can create a cat without bad habits.
        [TestMethod]
        public void CreateCatGood()
        {
            //arrange
            SimpleDate birthDate = new SimpleDate(09, 06, 2020);
            string expected = null;

            //act
            Cat cat = new Cat(1234, birthDate, "Hans", null);

            //assert
            StringAssert.Equals(cat.BadHabits, expected);
        }
        //This method tests wheter you can create a cat with bad habits.
        [TestMethod]
        public void CreateCatBad()
        {
            //arrange
            SimpleDate birthDate = new SimpleDate(09, 06, 2020);
            string expected = "Biting";

            //act
            Cat cat = new Cat(1234, birthDate, "Hans", "Biting");

            //assert
            StringAssert.Equals(cat.BadHabits, expected);
        }
    }
}
