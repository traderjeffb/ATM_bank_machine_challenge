using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Model;

namespace Services
{
    public class CustomerService
    {
        public void CreateCustomer(int id, string first, string last, int account_id)
        {
            var entity = new Customer
            {
                CustomerID = id,
                LastNamePrimary = last,
                FirstNamePrimary = first,
                AccountID = account_id
            };
            using (var ctx = new Bank_ATMEntities())
            {
                ctx.Customers.Add(entity);
                ctx.SaveChanges();
            };
        }
    }

}
