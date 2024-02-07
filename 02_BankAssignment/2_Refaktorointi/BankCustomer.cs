using BankAccountNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Yksikkotestit
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
    }
}
