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
            Console.WriteLine(FiggleFonts.Standard.Render("Hello"));

            AuthService authService = new AuthService();
            Console.WriteLine("enter your pin");
            var pin = Int32.Parse(Console.ReadLine());
            authService.VerifyAccount(pin);


  
            BankController demo = new BankController();
            demo.Add_Customer();



        }
    }
}
