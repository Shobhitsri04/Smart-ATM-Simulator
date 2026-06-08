using System;

namespace Test
{
    public class menu
    {
        public void options()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("\tWelcome to Simple Banking System");
            Console.WriteLine("==================================================\n");
            Console.WriteLine("---Bank Menu---\n");
            Console.WriteLine("1.Create Account");
            Console.WriteLine("2.Deposit Money");
            Console.WriteLine("3.Withdraw Money");
            Console.WriteLine("4.Check Balance");
            Console.WriteLine("5.View Account details");
            Console.WriteLine("6.List All Accounts");
            Console.WriteLine("7.Exit");
            Console.Write("\nEnter your choice(1-7):");
        }
    }
}