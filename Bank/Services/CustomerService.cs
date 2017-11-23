using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models;

namespace Services
{
    public class CustomerService
    {
        public void CreateCustomer( string first, string last)
        {
            
            using (var ctx = new Bank_ATMEntities())
            {
                var entity = new Customer
                {

                    LastNamePrimary = last,
                    FirstNamePrimary = first,
                    CustomerID = 1234

                };
                ctx.Customers.Add(entity);
                ctx.SaveChanges();
            };
        }
    }

}
