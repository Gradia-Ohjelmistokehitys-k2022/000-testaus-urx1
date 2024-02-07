using BankCustomerNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountNS
{
    public class BankAccount
    {
        public BankCustomer m_accountOwner {  get; set; }
        public double m_balance { get; set; }

        public BankAccount() { }

        public BankAccount(double balance) 

        {
            double m_balance = balance;
        }

        public BankAccount(BankCustomer accountOwner, double balance)

        {
            BankCustomer m_accountOwner = accountOwner;
            double m_balance = balance;
        }

        public static void CreateAccount(BankCustomer accountHolder, double balance)
        {
            BankCustomer m_accountOwner = accountHolder;
            double m_balance = balance;
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
    }
}
