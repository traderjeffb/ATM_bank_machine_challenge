using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models;

namespace Services
{
   public class AuthService
    {
        private Bank_ATMEntities db = new Bank_ATMEntities();

        public bool VerifyAccount(int account, int pin)
        {
            var query = from a in db.Accounts
                      where a.AccountNumber == account && a.PIN == pin
                      select a;
            foreach (var acct in query )
            {
                Console.WriteLine("Welcome to your account");
                return true;
            }
            Console.WriteLine("Wrong pin or account number please enter correct pin and account number again");
            return false;
        }
    }
}
