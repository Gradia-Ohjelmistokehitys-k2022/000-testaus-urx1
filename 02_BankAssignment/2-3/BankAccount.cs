using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankCustomerNS;

namespace BankAccountNS
{
    public class BankAccount
    {
        public int m_accountId;
        public string m_accountType;
        public BankCustomer m_accountOwner;
        public double m_balance;
        /*
        public override string ToString()
        {
            return "BankAccount: " + m_accountOwner + " Balance: " + m_balance;
        }
        */

        public BankAccount() { }

        public BankAccount(int accountId, string accountType, BankCustomer accountOwner, double balance)
        {
            m_accountId = accountId;
            m_accountType = accountType;
            m_accountOwner = accountOwner;
            m_balance = balance;
        }

        public double Balance
        {
            get { return m_balance; }
        }

        public static void CreateAccount(int accountId, string accountType, BankCustomer accountOwner, double balance) 
        { 
            BankAccount account = new BankAccount(accountId, accountType, accountOwner, balance);
            accountOwner.m_accounts.Add(account);
        }

        public static void DeleteAccount(BankCustomer accountOwner, int deleteId)
        {
                var accountToRemove = accountOwner.Accounts.Single(r => r.m_accountId == deleteId);
                accountOwner.Accounts.Remove(accountToRemove);   
        }

        public static void ShowAccounts(BankCustomer accountOwner)
        {
            foreach (BankAccount m_account in accountOwner.Accounts)
            {
                Console.WriteLine(accountOwner.m_customerName + " " + m_account.m_accountId + " " + m_account.m_accountType + " " + m_account.m_balance);
            }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance -= amount;
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance -= amount;
        }
    }
}
