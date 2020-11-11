using Microsoft.VisualStudio.TestTools.UnitTesting;
using BigBucksBankWithoutExceptions;
using System;

namespace BIgBankTesting
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void InitializeTest()
        {
            Account account = new Account("Kaas");

            Assert.IsNotNull(account);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Name was null")]
        public void WrongInitializeTest()
        {
            Account account = new Account(null);
        }
        [TestMethod]
        public void WithdrawTest()
        {
            Account account = new Account("Kaas", 1000);
            int expected = 800;

            account.Withdraw(200);

            Assert.AreEqual(expected, account.Balance);
        }
        [TestMethod]
        [ExpectedException(typeof(NotEnoughCreditException))]
        public void NoCreditWithdrawTest()
        {
            Account account = new Account("Kaas", 0);

            account.Withdraw(20000);
        }
        [TestMethod]
        public void DepositTest()
        {
            Account account = new Account("Kaas", 150);
            int expected = 250;

            account.Deposit(100);

            Assert.AreEqual(expected, account.Balance);
        }
    }
}
