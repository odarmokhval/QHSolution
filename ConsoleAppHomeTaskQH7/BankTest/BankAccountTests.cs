using System;
using BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BankTest
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            // act
            account.Debit(debitAmount);
            // assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        /* my var
         [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            try
            {
                // arrange
                double beginningBalance = 11.99;
                double debitAmount = -100.00;
                BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
                // act
                account.Debit(debitAmount);
                // assert is handled by ExpectedException
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("amount is less zero"));
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            try
            {
                // arrange
                double beginningBalance = 11.99;
                double debitAmount = 100.00;
                BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
                // act
                account.Debit(debitAmount);
                // assert is handled by ExpectedException
            }
            catch(Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("amount is greater than balance"));
                throw;
            }  */

        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // arrange
            double beginningBalance = 11.99;
            double debitAmount = 20.0;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            // act
            try
            {
                account.Debit(debitAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // assert
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
            }
            Assert.Fail("No exception was thrown.");
        }
    }                 
 }
