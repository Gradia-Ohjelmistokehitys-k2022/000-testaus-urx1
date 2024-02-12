using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BankAccountNS;

namespace BankCustomerNS
{

    //Tee BankCustomerista pääluokka
    //  -propertynä name
    //  -propertyna accounts (array/list?)
    //Alaluokaksi BankAccount
    //  -propertyna balance
    //Luo BankCustomerille metodi AddAccount
    //   -Lisää uuden objektin BankAccount propertyyn accounts

    public class BankCustomer
    {
        public string m_customerName;
        public List<BankAccount> m_accounts;

        public override string ToString()
        {
            return "BankCustomer: " + m_customerName + " " + String.Join(" ", m_accounts);
        }

        public BankCustomer() { }


        public string CustomerName
        {
            get { return m_customerName; }
        }

        public List<BankAccount> Accounts
        {
            get { return m_accounts; }
        }

        public static void Main()
        {
            var cust1 = new BankCustomer
            {
                m_customerName = "Mr. Bryan Walton",
                m_accounts = new List<BankAccount>()
            };
            BankAccount.CreateAccount(1, "Debit", cust1, 100);
            BankAccount.CreateAccount(2, "Credit", cust1, 100);
            BankAccount.ShowAccounts(cust1);
            BankAccount.TransferMoney(cust1.m_accounts[0], cust1.m_accounts[1], 25.00D);
            BankAccount.ShowAccounts(cust1);

            //Console.WriteLine(cust1.m_accounts.Count)
            //Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}