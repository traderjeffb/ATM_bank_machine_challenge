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
        private AuthService authService = new AuthService();

        public void Add_Customer()
        {
            Console.WriteLine("enter first name");
            string first = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("enter last name");
            string last = Console.ReadLine();
            customerService.CreateCustomer(first, last);
        }



        public void VerifyAccountInConsole()
        {

            Console.WriteLine("Please enter an account number:");
            string accountString = Console.ReadLine();
            int account = Int32.Parse(accountString);

            Console.WriteLine("enter your pin");
            string pinString = Console.ReadLine();
            int pin = Int32.Parse(pinString);

            authService.VerifyAccount(account, pin);
        }



        
    }
}
