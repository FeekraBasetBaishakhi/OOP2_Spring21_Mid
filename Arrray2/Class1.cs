using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Acc a = new Acc();
            a.AccName = "Anjuman";
            a.AccId = "39015";
            a.Balance = 20000;
            a.Deposite(5000);
            a.Withdraw(2000);
            a.Transfer(100000, a);
            a.ShowInfo();

        }
    }
}
