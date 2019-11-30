using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankAccountNS;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public double Balance { get; private set; }
        public object CreditAmount { get; private set; }

        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double creditAmount = 4.55;
            double expected = 7.44;
            UnitTest1 account = new BankAccount("Mr.PC", beginningBalance);

            // Act
            account.credit(CreditAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        private void credit(object creditAmount)
        {
            throw new NotImplementedException();
        }

        private void Credit(double debitAmount)
        {
            throw new NotImplementedException();
        }



        public static implicit operator UnitTest1(BankAccount v)
        {
            throw new NotImplementedException();
        }
    }
}