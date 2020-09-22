using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PiggyBankAssignment;

namespace PiggyBankAssignmentTest
{
    [TestClass]
    public class PiggyBankTest
    {
        [TestMethod]
        public void TestCreationWithoutInitialSavings()
        {
            PiggyBank piggyBank = new PiggyBank();
            Assert.AreEqual(0, piggyBank.Savings);
        }

        [TestMethod]
        public void TestCreationWithZeroSavings()
        {
            PiggyBank piggyBank = new PiggyBank(0);
            Assert.AreEqual(0, piggyBank.Savings);
        }

        [TestMethod]
        public void TestCreationWithNegativeSavings()
        {
            PiggyBank piggyBank = new PiggyBank(-1);
            Assert.AreEqual(0, piggyBank.Savings);
        }

        [TestMethod]
        public void TestCreationWithPositiveSavings()
        {
            PiggyBank piggyBank = new PiggyBank(1);
            Assert.AreEqual(1, piggyBank.Savings);
        }

        [TestMethod]
        public void TestSavingAZeroAmount()
        {
            PiggyBank piggyBank = new PiggyBank(20);
            piggyBank.Save(0);
            Assert.AreEqual(20, piggyBank.Savings);
        }

        [TestMethod]
        public void TestSavingAPositiveAmount()
        {
            PiggyBank piggyBank = new PiggyBank(20);
            piggyBank.Save(1);
            Assert.AreEqual(21, piggyBank.Savings);
        }

        [TestMethod]
        public void TestSavingANegativeAmount()
        {
            PiggyBank piggyBank = new PiggyBank(20);
            piggyBank.Save(-1);
            Assert.AreEqual(20, piggyBank.Savings);
        }

        [TestMethod]
        public void TestRemovingAZeroAmount()
        {
            PiggyBank piggyBank = new PiggyBank(20);
            int removed = piggyBank.Remove(0);
            Assert.AreEqual(0, removed);
            Assert.AreEqual(20, piggyBank.Savings);
        }

        [TestMethod]
        public void TestRemovingAPositiveAmount()
        {
            PiggyBank piggyBank = new PiggyBank(20);
            int removed = piggyBank.Remove(1);
            Assert.AreEqual(1, removed);
            Assert.AreEqual(19, piggyBank.Savings);
        }

        [TestMethod]
        public void TestRemovingANegativeAmount()
        {
            PiggyBank piggyBank = new PiggyBank(20);
            int removed = piggyBank.Remove(-1);
            Assert.AreEqual(0, removed);
            Assert.AreEqual(20, piggyBank.Savings);
        }

        [TestMethod]
        public void TestRemovingTheExactAmountOfSavings()
        {
            PiggyBank piggyBank = new PiggyBank(20);
            int removed = piggyBank.Remove(20);
            Assert.AreEqual(20, removed);
            Assert.AreEqual(0, piggyBank.Savings);
        }

        [TestMethod]
        public void TestRemovingMoreThanTheSavings()
        {
            PiggyBank piggyBank = new PiggyBank(20);
            int removed = piggyBank.Remove(21);
            Assert.AreEqual(20, removed);
            Assert.AreEqual(0, piggyBank.Savings);
        }

        [TestMethod]
        public void TestRemovingOneLessThanTheSavings()
        {
            PiggyBank piggyBank = new PiggyBank(20);
            int removed = piggyBank.Remove(19);
            Assert.AreEqual(19, removed);
            Assert.AreEqual(1, piggyBank.Savings);
        }
    }
}
