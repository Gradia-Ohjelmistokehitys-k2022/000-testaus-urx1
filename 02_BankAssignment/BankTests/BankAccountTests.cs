using BankAccountNS;
using BankCustomerNS;
using System;
using System.Security.Principal;

namespace BankTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double creditAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Credit(creditAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]
        public void Debit_WithNegativeAmount()
        {
            double beginningBalance = 11.99;
            double debitAmount = 4.55;

            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            account.Debit(debitAmount);

            if (debitAmount < 0)
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Balance);
            }
        }
        [TestMethod]
        public void CreateDebitAccount_WithNegativeAmount()
        {
            double beginningBalance = 11.99;

            var cust1 = new BankCustomer
            {
                m_customerName = "Mr. Bryan Walton",
                m_accounts = new List<BankAccount>()
            };
            
            BankAccount.CreateAccount(1, "Debit", cust1, beginningBalance);


            if (beginningBalance < 0)
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => beginningBalance);
            }
        }
        [TestMethod]
        public void CreateCreditAccount_WithNegativeAmount()
        {

            double beginningBalance = 234.2;
            var cust1 = new BankCustomer
            {
                m_customerName = "Mr. Bryan Walton",
                m_accounts = new List<BankAccount>()
            };

            BankAccount.CreateAccount(1, "Credit", cust1, beginningBalance);


            if (beginningBalance < 0)
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => beginningBalance);
            }
        }
        [TestMethod]
        public void CreateAccount_WithSameId()
        {
            var cust1 = new BankCustomer
            {
                m_customerName = "Mr. Bryan Walton",
                m_accounts = new List<BankAccount>()
            };

            BankAccount.CreateAccount(1, "Credit", cust1, 123.45);
            BankAccount.CreateAccount(2, "Debit", cust1, 234.567);

            foreach (BankAccount m_account in cust1.Accounts)
            {
                if (cust1.m_accounts[0].m_accountId == cust1.m_accounts[1].m_accountId)
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => cust1.m_accounts[1].m_accountId);
            }
        }
        [TestMethod]
        public void CreateAccount_WithWrongType()
        {
            var cust1 = new BankCustomer
            {
                m_customerName = "Mr. Bryan Walton",
                m_accounts = new List<BankAccount>()
            };

            BankAccount.CreateAccount(1, "Credit", cust1, 123.45);
            BankAccount.CreateAccount(2, "Debit", cust1, 123.45);

            foreach (BankAccount m_account in cust1.Accounts)
            {
                if (m_account.m_accountType == "Debit" ||
                    m_account.m_accountType == "Credit")
                {
                    return;
                }
                else
                {
                    Assert.ThrowsException<ArgumentOutOfRangeException>(() => m_account.m_accountType);
                }
            }
        }

        [TestMethod]
        public void TransferMoney_WithValidAmount_UpdatesBalance()
            //HUOM tämä testaa myös koko polun
        {

            double expectedAcc1 = 100;
            double expectedAcc2 = 100;
            var cust1 = new BankCustomer
            {
                m_customerName = "Mr. Bryan Walton",
                m_accounts = new List<BankAccount>()
            };
            
            BankAccount.CreateAccount(1, "Credit", cust1, 125);
            BankAccount.CreateAccount(2, "Debit", cust1, 75);
            BankAccount.TransferMoney(cust1.m_accounts[0], cust1.m_accounts[1], 25.00D);

            if (cust1.m_accounts[0].m_balance != expectedAcc1)
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => cust1.m_accounts[0].m_balance);
            }
            if (cust1.m_accounts[1].m_balance != expectedAcc2)
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => cust1.m_accounts[1].m_balance);
            }
        }
    }
}