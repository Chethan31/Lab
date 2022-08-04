using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class AccountManager
    {
        /// <summary>
        /// Method to store account details into the account object passed
        /// </summary>
        /// <param name="Acc"></param>
        public void FillAccountData(Account Acc)
        {
            Acc._AccNo = "004701";
            Acc._Name = "Nitesh";
            Acc._Balance = 45000.0;
        }

        /// <summary>
        /// Method to display account details from the account object passed
        /// </summary>
        /// <param name="Acc"></param>
        public void DisplayAccountData(Account Acc)
        {
            //Write code to display the Account
            //object
            Console.WriteLine("AccNo : " + Acc._AccNo);
            Console.WriteLine("Name : " + Acc._Name);
            Console.WriteLine("Balance : " + Acc._Balance);
        }
    }
}
