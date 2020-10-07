using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnimalShelter
{
    public class Administration
    {
        public List<Animal> Animals { get; private set; }
        private List<string> content;
        private string path = @"C:\Users\joeyo\Desktop\Fontys\Semester 2\t-db-prc2-joey_oonincx\src\OOP code\Inheritance\Animals.txt";

        public Administration()
        {
            SimpleDate birth = new SimpleDate(9, 4, 2020);
            Animal dog = new Dog(124, birth, "hans", null);
            Animal cat = new Cat(125, birth, "Peta", null);
            Animals = new List<Animal>();
            AddAnimal(dog);
            AddAnimal(cat);
        }

        /// <summary>
        /// Saves all animals to a file with the given file name using serialisation.
        /// </summary>
        /// <param name="fileName">The file to write to.</param>
        public void Save(string fileName)
        {
            if (!File.Exists(path))
            {
                writeFile("Exists");
            }
            else
            {
                File.Create(path);
                writeFile("Created");
            }
        }
        public void writeFile(string content)
        {
            StreamWriter sw = File.CreateText(path);
            try
            {
                sw.WriteLine(content);
            }
            catch (IOException ex)
            {
                throw new IOException(ex.Message);
            }
            finally
            {
                sw.Close();
            }

        }
        /// <summary>
        /// Loads all animals from a file with the given file name using deserialisation.
        /// All animals currently in the administration are removed.
        /// </summary>
        /// <param name="fileName">The file to read from.</param>
        public void Load(string fileName)
        {
            StreamReader sr = new StreamReader(path);
            content = new List<string>();
            try
            {
                do
                {
                    content.Add(sr.ReadLine());
                }
                while (sr.Peek() != -1);
            }

            catch(IOException ex)
            {
                throw new IOException(ex.Message);
            }
            finally
            {
                sr.Close();
            }
        }

        /// <summary>
        /// Exports the info of all animals to a text file with the given file name.
        /// 
        /// Each line of the file contains the info about exactly one animal.
        /// Each line starts with the type of animal and a colon (e.g. 'Cat:' or 'Dog:')
        /// followed by the properties of the animal seperated by comma's.
        /// </summary>
        /// <param name="fileName">The text file to write to.</param>
        public void Export(string fileName)
        {

        }

        public bool AddAnimal(Animal Animal)
        {
            if(FindAnimal(Animal.ChipRegistrationNumber) != null)
            {
                return false;
            }
            else
            {
                Animals.Add(Animal);
                return true;
            }
        }
        public bool RemoveAnimal(int chipRegistrationNumber)
        {
            return Animals.Remove(FindAnimal(chipRegistrationNumber));
        }
        public Animal FindAnimal(int chipRegristrationNumber)
        {
            Animal foundAnimal = null;
            foreach(Animal animal in Animals)
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
