using BankAccountNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustomer
{
    internal class BankCustomer
    {
        private readonly string m_customerName;
        private Array m_accounts;
        private BankCustomer() { }
        
        private BankCustomer(string customerName, Array accounts)
        {
            m_customerName = customerName;
            m_accounts = accounts;
        }
        public void AddAccount(BankAccount account, m_customerName, initialBalance)
        {
            BankAccount account1 = new BankAccount("Mr. Bryan Walton", 123.23);
        }
    }
}
