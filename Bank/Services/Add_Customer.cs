using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
  public  class AddCustomer
    {
        public void Add_Customer()
        {
            CustomerService customer = new CustomerService();
            Console.WriteLine("enter first name");
            string first = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("enter last name");
            string last = Console.ReadLine();
            customer.CreateCustomer(first, last);
        }

    }
}
