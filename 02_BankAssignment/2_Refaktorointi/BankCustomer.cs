using BankAccountNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustomerNS
{
    public class BankCustomer
    {
        public string m_customerName;
        private Array m_accounts;
        private BankCustomer() { }

        public BankCustomer(string customerName)
        {
            m_customerName = customerName;
        }
        public BankCustomer(string customerName, Array accounts)
        {
            m_customerName = customerName;
            m_accounts = accounts;
        }

    }
}
