using System;
using BankAccountNS;


namespace BankCustomerNS
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class BankCustomer
    {
        public string m_customerName { get; set; }
        public BankAccount m_bankAccount { get; set; }

        public BankCustomer() { }

        public BankCustomer(string customerName)
        {
            m_customerName = customerName;
        }

        public BankCustomer(string customerName, BankAccount bankAccount)
        {
            m_customerName = customerName;
            m_bankAccount = bankAccount;
        }


        public static void Main()
        {
            BankCustomer cust1 = new BankCustomer("Timo Perkele");
            Console.WriteLine(cust1.m_customerName);
            BankAccount acc1 = new BankAccount(cust1,123.23); //palauttaa 0?
            Console.WriteLine(acc1.m_balance);
            //BankAccount.CreateAccount(cust1, 123.23);
            Console.WriteLine(cust1.m_customerName);
            BankAccount.CreateAccount(1, cust1, 123);
            Console.WriteLine(cust1.m_bankAccount.ToString());
        }
    }
}