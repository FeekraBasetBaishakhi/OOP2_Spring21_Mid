using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Acc
    {
        private string accName;
        private string accid;
        private int balance;
        public String AccName
        {
            set
            {
                accName = value;
            }
            get
            {
                return accName;
            }

        }
        public String AccId
        {
            set
            {
                accid = value;
            }
            get
            {
                return accid;
            }

        }

        public int Balance
        {
            set
            {
                balance = value;
            }
            get
            {
                return balance;
            }

        }
        public void Deposite(int amount)
        {
            balance += amount;
            Console.WriteLine("Deposite : " + balance);
        }
        public int getBalance()
        {
            return balance;
        }
        public void Withdraw(int amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("Insufficient amount : ");
            }
            else
            {

                balance -= amount;
                Console.WriteLine("Withdraw : " + balance);
            }
        }
        public void Transfer(int amount, Acc receiver)
        {
            Console.WriteLine("Enter amount to transfer");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The reciever Account id");
            receiver.AccId = Console.ReadLine();
            if (balance > amount)
            {
                balance -= amount;
                Console.WriteLine("Amount" + amount + "Transfered to" + receiver);
            }

            else
            {
                Console.WriteLine("Invalid Transaction");

            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name : " + accName + "\nID : " + accid + "\nBalance : " + balance);
            Console.ReadKey();
        }
    }
}