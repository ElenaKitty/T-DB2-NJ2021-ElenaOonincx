using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        /// <summary>
        /// The (only) animal in this administration (for now....)
        /// </summary>
        Administration admin;

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
            admin = new Administration();
            foreach (Animal animal in admin.Animals)
            {
                animalBox.Items.Add(animal);
            }
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            Animal animal = null;
            int chipNumber;
            int.TryParse(chipBox.Text, out chipNumber);
            SimpleDate birth = new SimpleDate(birthBox.Value.Day, birthBox.Value.Month, birthBox.Value.Year);
            SimpleDate walk = new SimpleDate(walkBox.Value.Day, walkBox.Value.Month, walkBox.Value.Year);
            if (animalTypeComboBox.Text == "Dog")
            {                
                animal = new Dog(chipNumber, birth, nameBox.Text, walk);
                MessageBox.Show("Dog created");
            }
            if (animalTypeComboBox.Text == "Cat")
            {
                animal = new Cat(chipNumber, birth, nameBox.Text, habitsBox.Text);
                MessageBox.Show("Cat created");
            }
            admin.AddAnimal(animal);
            animalBox.Items.Add(animal);
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            
            if(animalBox.Items is null)
            {
                outputBox.Text = "No animal registered";
            }
            else if(animalBox.SelectedItem is Dog)
            {
                outputBox.Text = animalBox.SelectedItem.ToString();
            }
            else if(animalBox.SelectedItem is Cat)
            {
                outputBox.Text = animalBox.SelectedItem.ToString();
            }
            else
            {
                outputBox.Text = "Something went wrong";
            }
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            reservedBox.Items.Add(animalBox.SelectedItem);
            Animal animal = (Animal)animalBox.SelectedItem;
            animal.IsReserved = true;
            animalBox.Items.Remove(animalBox.SelectedItem);
        }

        private void unreserveButton_Click(object sender, EventArgs e)
        {
            animalBox.Items.Add(reservedBox.SelectedItem);
            Animal animal = (Animal)reservedBox.SelectedItem;
            animal.IsReserved = false;
            reservedBox.Items.Remove(reservedBox.SelectedItem);
        }
    }
}
