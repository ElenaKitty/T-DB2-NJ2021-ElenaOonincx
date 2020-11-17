using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksBankWithoutExceptions
{
    public partial class MainForm : Form
    {
        private Account account;

        public MainForm()
        {
            InitializeComponent();
            groupBox4.Enabled = false;
            account = null;
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            decimal initialBalance;
            if (nameTextBox.Text.Length != 0
                && Decimal.TryParse(initialBalanceTextBox.Text, out initialBalance))
            {
                try
                {
                    account = new Account(nameTextBox.Text, initialBalance);
                    groupBox4.Enabled = true;
                    ShowAccountInfo();
                }
                catch(ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid information.");
            }
        }

        private void ShowAccountInfo()
        {
            nameInfoTextBox.Text = account.Name;
            maxDepthInfoTextBox.Text = account.MaxDebt.ToString();
            balanceInfoTextBox.Text = account.Balance.ToString();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (Decimal.TryParse(depositAmountTextBox.Text, out amount))
            {
                account.Deposit(amount);
                ShowAccountInfo();
            }
            else
            {
                MessageBox.Show("Please enter valid information.");
            }
        }

        private void withDrawButton_Click(object sender, EventArgs e)
        {
            decimal amount;
            bool bounced = false; ;
            if (Decimal.TryParse(withdrawAmountTextBox.Text, out amount))
            {
                try
                {
                    bounced = !account.Withdraw(amount);
                    ShowAccountInfo();
                }
                catch(NotEnoughCreditException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid information.");
            }
        }
    }
}
