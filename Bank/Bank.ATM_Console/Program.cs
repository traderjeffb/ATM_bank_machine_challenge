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

            //Change: I moved the Auth method over to the controller. I'm striving to slim down
            //this file for strictly firing up the app.

            BankController anInstanceOfBankControllerThatICanUseToCallMethods = new BankController();
            anInstanceOfBankControllerThatICanUseToCallMethods.VerifyAccountInConsole();
           
            //Console.WriteLine("before");
            //TransactionChoice transaction = new TransactionChoice();
            //Console.WriteLine("after");
            



        }
    }
}
