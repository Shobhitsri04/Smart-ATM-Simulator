using System;
using System.Linq;



namespace Test
{
    public class depositamount
    {
        private static Account foundAccount;

        //method to check if account exists or not 
        public static Account checkAccount()
        {
            int AC;
            while (true)
            {
                Console.Write("Enter Account Number:");
                string tAC = Console.ReadLine();
                if (tAC.ToLower() == "exit") return null;
                if (int.TryParse(tAC, out AC))
                    break;
                Console.WriteLine("Invalid Input!!!");
            }
            foundAccount = Account.AllAccounts.FirstOrDefault(a => a.AccountNumber == AC);//lambda function to find account.allAccount is a list in another which i have made public for access here 
            if (foundAccount == null)
            {
                Console.WriteLine("Account does not exist!create account to continue");
                return null;
            }
            return foundAccount;
        }

        public static void checkPIN()
        {
            int attempts = 3;
            string p;
            int PIN;
            while (true)
            {
                Console.Write("Enter PIN:");
                p = Console.ReadLine().Trim();
                if (int.TryParse(p, out PIN) && foundAccount.verifyPIN(PIN))
                    break;

                Console.WriteLine("Incorrect PIN");
                attempts--;
                if (attempts == 2) Console.WriteLine($"Only {attempts} attempt(s) left");

                if (attempts == 1) Console.WriteLine($"Only {attempts} attempt(s) left");

                if (attempts == 0) Console.WriteLine("Account Blocked for 24 hours");

            }
        }
    }


}