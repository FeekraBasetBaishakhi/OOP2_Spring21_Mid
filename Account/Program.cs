using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private string accName;
        private string accId;
        private int balance;
        private int amount1;
        private int amount2;
        public static void Main(string[] args)
        {
            Account a1 = new Account();
            Account a2 = new Account("Feekra Baset ", "A5X64Y0", 2000,900,400);
            a2.ShowDetails();

        }
        public Account()
        {
            Console.WriteLine("Empty -Account");
        }
        public Account(string accName, string accId, int balance,int amount1,int amount2)
        {

            this.accName = accName;
            this.accId = accId;
            this.balance = balance;
            this.amount1 = amount1;
            this.amount2 = amount2;

            Console.WriteLine("Parameterized Account");
        }



        public void ShowDetails()
        {
            Console.WriteLine("Account Name is: " + accName);
            Console.WriteLine("Account ID is: " + accId);
            Console.WriteLine("Account Balance: " + balance);
            Console.WriteLine("Account deposited: " + (balance+amount1));
            Console.WriteLine("Account withdraw: " + (balance-amount2));


        }
    }
}
