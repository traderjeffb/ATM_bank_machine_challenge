using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;
using Services;



namespace Bank.ATM_Console
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine(FiggleFonts.Standard.Render("Welcome to 1150 Bank"));
        
            //authorizes pin number
            AuthService authService = new AuthService();
            Console.WriteLine("enter your pin");
            var pin = Int32.Parse(Console.ReadLine());
            authService.VerifyAccount(pin);

            Console.WriteLine("before");
            TransactionChoice transaction = new TransactionChoice();
            Console.WriteLine("after");
            


  
        //    BankController demo = new BankController();
         //   demo.Add_Customer();



        }
    }
}
