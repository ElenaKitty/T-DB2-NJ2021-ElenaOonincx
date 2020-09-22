using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBankAssignment
{
    public partial class MainForm : Form
    {
        private PiggyBank piggyBank;

        public MainForm()
        {
            InitializeComponent();
            piggyBank = new PiggyBank(20);
            UpdateSavingsLabel();
        }

        private void UpdateSavingsLabel()
        {
            savingsLabel.Text = piggyBank.Savings.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int amount;
            bool isConverted = Int32.TryParse(amountTextBox.Text, out amount);
            if (isConverted)
            {
                piggyBank.Save(amount);
                UpdateSavingsLabel();
            }
            else
            {
                MessageBox.Show("Please enter a valid amount to save.");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int amount;
            bool isConverted = Int32.TryParse(amountTextBox.Text, out amount);
            if (isConverted)
            {
                piggyBank.Remove(amount);
                UpdateSavingsLabel();
            }
            else
            {
                MessageBox.Show("Please enter a valid amount to remove.");
            }
        }
    }
}
