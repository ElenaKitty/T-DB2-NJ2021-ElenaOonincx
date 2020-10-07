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
    public partial class TestForm : Form
    {
        List<Animal> animals = new List<Animal>();
        public TestForm()
        {
            InitializeComponent();
            SimpleDate birth = new SimpleDate(4, 5, 6);
            SimpleDate birth2 = new SimpleDate(7, 2, 20);
            //Dog dog1 = new Dog(1234,)
            //Dog dog2 = new Dog();
            //Dog dog3 = new Dog();
            //Cat cat1 = new Cat();
            //Cat cat2 = new Cat();
            //Cat cat3 = new Cat();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }
    }
}
