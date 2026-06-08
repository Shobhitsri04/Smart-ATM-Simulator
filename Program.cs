using System;

namespace Test
{
    class Program : Account
    {
        static void Main()
        {
            Program obj = new Program();
            obj.options();
            string choice;
            bool flag = true;
            while (flag)
            {
                obj.options();
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        obj.CreateAccount();
                        break;
                    case "2":
                        obj.DepositMoney();
                        break;
                    case "3":
                        obj.WithdrawMoney();
                        break;
                    case "4":
                        obj.CheckBalance();
                        break;
                    case "5":
                        obj.AccountDetails();
                        break;
                    case "6":
                        obj.ListAccounts();
                        break;
                    case "7":
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid input!!!!");
                        break;
                }
                Console.WriteLine("\nDo you wish to continue(yes/no):");
                string c = Console.ReadLine();
                c = c.ToLower().Trim();
                if (c == "yes")
                {
                    flag = true;
                }
                else if (c == "no")
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("Program terminated!!!");
                    Environment.Exit(0);
                }

            }
        }
    }
}