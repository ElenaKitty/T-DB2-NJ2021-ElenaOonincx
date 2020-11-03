using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Administration
    {
        public List<Animal> animals = new List<Animal>();
        public Administration()
        {
            SimpleDate birth = new SimpleDate(9, 4, 2020);
            Animal dog = new Dog(3450, birth, "hans", null);
            Animal cat = new Cat(12, birth, "Peta", null);
            AddAnimal(dog);
            AddAnimal(cat);
        }
        public bool AddAnimal(Animal Animal)
        {
            bool exists = false;
            foreach(Animal animal in animals)
            {
                if(animal.ChipRegistrationNumber == Animal.ChipRegistrationNumber)
                {
                    exists = true;
                }
            }
            if(exists)
            {
                return false;
            }
            else
            {
                animals.Add(Animal);
                return true;
            }
        }
        public bool RemoveAnimal(int chipRegistrationNumber)
        {
            foreach (Animal animal in animals)
            {
                if(animal.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    animals.Remove(animal);
                    return true;
                }
            }
            return false;
        }
        public Animal FindAnimal(int chipRegristrationNumber)
        {
            Animal foundAnimal = null;
            foreach(Animal animal in animals)
            {
                if(animal.ChipRegistrationNumber == chipRegristrationNumber)
                {
                    foundAnimal = animal;
                }
            }
            return foundAnimal;
        }
    }
}
