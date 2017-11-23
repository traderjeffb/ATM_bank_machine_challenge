using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;

namespace Bank.ATM_Console
{
    public class BankController
    {

        private CustomerService customerService = new CustomerService();
       // private AccountService accountService = new AccountService();

        public void Add_Customer()
        {
            Console.WriteLine("enter first name");
            string first = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("enter last name");
            string last = Console.ReadLine();
            customerService.CreateCustomer(first, last);
        }

        public void Foo()
        {
            Console.WriteLine("Foo");
        }
    }
}
