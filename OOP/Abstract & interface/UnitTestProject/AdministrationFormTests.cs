using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalTests
{
    using AnimalShelter;
    [TestClass]
    public class AdministrationFormTests
    {
        [TestMethod]
        public void ShowDogInfoWalk()
        {
            string name = "Hans";
            int chipNumber = 1324123;
            SimpleDate birth = new SimpleDate(05, 05, 1994);
            SimpleDate lastWalk = new SimpleDate(10, 05, 1994);
            string expected = "Dog: " + chipNumber + ", " + birth + ", " + name + ", Reserved," + lastWalk;
            Dog dog = new Dog(chipNumber, birth, name, lastWalk);

            string result = dog.ToString();

            StringAssert.Equals(result, expected);
        }

        [TestMethod]
        public void ShowCatInfoHabits()
        {
            string name = "Hans";
            int chipNumber = 1324123;
            string habits = "biting";
            SimpleDate birth = new SimpleDate(05, 05, 1994);
            string expected = "Cat: " + chipNumber + ", " + birth + ", " + name + ", Reserved," + habits;
            Cat cat = new Cat(chipNumber, birth, name, habits);

            string result = cat.ToString();

            StringAssert.Equals(result, expected);
        }
        [TestMethod]
        public void ShowNoInfoNoAnimal()
        {
            Animal animal = null;
            string expected = "No animal registered";
            string result = "";

            if(animal == null)
            {
                result = "No animal registered";
            }

            StringAssert.Equals(result, expected);
        }
    }
}
