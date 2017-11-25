using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public  class TransactionChoice
    {
            public int TransactionMenu()
        {
              Console.WriteLine("Please choose \n" +
                    "1. Withdraw Money \n" +
                    "2. Deposit Money\n" +
                    "3. Check Balance");
            int choice = Int32.Parse(Console.ReadLine());
            return choice;
        }

    }
}
