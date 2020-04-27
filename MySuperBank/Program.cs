using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Jimbo", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with ${account.Balance}.");

            account.MakeWithdrawl(120, DateTime.Now, "Hammock");       
            account.MakeWithdrawl(50, DateTime.Now, "Xbox Game");
           

            Console.WriteLine(account.GetAccountHistory());








            //// Test that the initial balances must be positive.
            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}


        }

    }
}
