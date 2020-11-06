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


    }
}
