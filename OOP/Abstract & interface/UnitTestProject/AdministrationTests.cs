using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalTests
{
    using AnimalShelter;
    using System.Collections.Generic;

    [TestClass]
    public class AdministrationTests
    {
        //Checks if you can Add a new animal
        [TestMethod]
        public void AddAnimalGood()
        {
            //Arrange
            SimpleDate birthDate = new SimpleDate(09, 06, 2020);
            Administration admin = new Administration();
            Animal animal = new Dog(1234, birthDate, "Test", birthDate);
            List<Animal> expected = new List<Animal>();
            expected.Add(animal);

            //Act
            admin.AddAnimal(animal);

            //Assert
            CollectionAssert.Equals(expected, admin.animals);
        }
        //Checks if you can't add the same chipnumber
        [TestMethod]
        public void AddAnimalBad()
        {
            //Arrange
            SimpleDate birthDate = new SimpleDate(09, 06, 2020);
            Administration admin = new Administration();
            Animal animal = new Dog(1234, birthDate, "Test", birthDate);
            Animal animal2 = new Cat(1234, birthDate, "Hans", "");
            List<Animal> expected = new List<Animal>();
            expected.Add(animal);
            admin.AddAnimal(animal);

            //Act
            admin.AddAnimal(animal2);

            //Assert
            CollectionAssert.Equals(expected, admin.animals);
        }
        //Checks if you can remove an animal
        [TestMethod]
        public void RemoveAnimalGood()
        {
            //Arrange
            SimpleDate birthDate = new SimpleDate(09, 06, 2020);
            Administration admin = new Administration();
            Animal animal = new Cat(1234, birthDate, "Test","");
            List<Animal> expected = new List<Animal>();
            admin.AddAnimal(animal);

            //Act
            admin.RemoveAnimal(animal.ChipRegistrationNumber);

            //Assert
            CollectionAssert.Equals(expected, admin.animals);
        }
        //Checks if you can't remove an animal cause it doesn't exist
        [TestMethod]
        public void RemoveAnimalBad()
        {
            //Arrange
            SimpleDate birthDate = new SimpleDate(09, 06, 2020);
            Administration admin = new Administration();
            Animal animal = new Cat(1234, birthDate, "Test","");
            List<Animal> expected = new List<Animal>();

            //Act
            admin.RemoveAnimal(animal.ChipRegistrationNumber);

            //Assert
            CollectionAssert.Equals(expected, admin.animals);
        }
        //Checks if you can find an existing animal
        [TestMethod]
        public void FindAnimalGood()
        {
            //Arrange
            SimpleDate birthDate = new SimpleDate(09, 06, 2020);
            Administration admin = new Administration();
            Animal animal = new Dog(1234, birthDate, "Test", birthDate);
            Animal expected = animal;
            admin.AddAnimal(animal);

            //Act
            Animal foundAnimal = admin.FindAnimal(animal.ChipRegistrationNumber);

            //Assert
            Assert.AreEqual(expected, foundAnimal);
        }
        //Checks if you can't find a non existing animal
        [TestMethod]
        public void FindAnimalBad()
        {
            //Arrange
            SimpleDate birthDate = new SimpleDate(09, 06, 2020);
            Administration admin = new Administration();
            Animal animal = new Dog(1234, birthDate, "Test", birthDate);
            Animal expected = null;

            //Act
            Animal foundAnimal = admin.FindAnimal(animal.ChipRegistrationNumber);

            //Assert
            Assert.AreEqual(expected, foundAnimal);
        }
    }
}
