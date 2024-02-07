using System;
using BankCustomerNS;


namespace BankAccountNS
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class BankAccount
    {
        private readonly string m_accountOwner;
        private double m_balance;

        private BankAccount() { }

        public BankAccount(string accountOwner, double balance)
        {
            m_accountOwner = accountOwner;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_accountOwner; }
        }

        public double Balance
        {
            get { return m_balance; }
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

        public static void Main()
        {
            BankCustomer c1 = new BankCustomer("Timo Perkele");
            Console.WriteLine(c1.m_customerName);
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}