using System;
using System.Collections.Generic;

namespace Test
{
    /// <summary>
    /// class Account contains all the required entries for account creation and usage 
    /// </summary>
    public class Account : menu
    {
        public static List<Account> allAccount = new List<Account>();

        public static IReadOnlyList<Account> AllAccounts => allAccount.AsReadOnly();

        public int AccountNumber { get; private set; }
        private string HolderName { get; set; }
        private string Accounttype { get; set; }
        private int Balance { get; set; }
        private int PIN { get; set; }

        public int InitialDeposit;


        public bool verifyPIN(int iPIN) => PIN == iPIN;

        
       //public Account(int ac,string acname,string type,int bal,int pin)
       // {
       //     AccountNumber = ac;
       //     HolderName = acname;
       //     Accounttype = type;
       //     Balance = bal;
       //     PIN = pin;
       // }


        public void CreateAccount()
        {
            string Name;
            string Type;
            int CPIN;
            //int Balance = 0;

            Console.WriteLine("\n----Create Account----");
            Console.Write("Enter account holder name:");
            Name = Console.ReadLine();
            while (true)
            {
                Console.Write("Enter account type(Savings/Current):");
                Type = Console.ReadLine().ToLower().Trim();
                if (Type == "savings" || Type == "current")
                    break;
                Console.WriteLine("Account type can only be savings or current! try again");
            }

            //PIN
            while (true)
            {
                Console.Write("Create PIN:");
                string spin = Console.ReadLine();
                if (spin.Length == 4 && int.TryParse(spin, out CPIN))
                    break;
                Console.WriteLine("create a valid pin");
            }

            //AT: Console.Write("Enter account type(Savings/Current):");
            //    Type = Console.ReadLine().ToLower();
            //    if (Type != "savings" && Type != "current")
            //    {
            //        Console.WriteLine("Account type can only be savings or current! try again");
            //        goto AT;
            //    }

            //Initial deposit
            while (true)
            {
                Console.Write("Enter initial deposit amount:");
                string tamount = Console.ReadLine();

                if (int.TryParse(tamount, out InitialDeposit))
                {
                    if (InitialDeposit >= 1500 && InitialDeposit <= 10000) break;
                    Console.WriteLine("Initial deposit amount must be between 1500 to 10000");
                }
                else
                {
                    Console.WriteLine("Enter a Valid value!!");
                }
            }
            //new Account
            Account newAccount = new Account
            {
                AccountNumber = allAccount.Count + 1,
                HolderName = Name,
                Accounttype = Type,
                Balance = InitialDeposit,
                PIN=CPIN
            };
            allAccount.Add(newAccount);
            Console.WriteLine("\nAccount created!");
            Console.WriteLine($"\nAccount Number:{newAccount.AccountNumber}");
            Console.WriteLine($"Account Holder:{newAccount.HolderName}");
            Console.WriteLine($"Account Type:{newAccount.Accounttype}");
            Console.WriteLine($"Clear Balance:{newAccount.Balance}");
            return;
        }

        //deposit money
        public void DepositMoney()
        {
            Console.WriteLine("----Deposit Money----");
            Account AC = depositamount.checkAccount();
            if (AC != null)
            {
                int amount;
                depositamount.checkPIN();
                Console.Write("Enter Deposit Amount:");
                amount = Convert.ToInt32(Console.ReadLine());
                AC.Balance += amount;
                Console.WriteLine($"Successfully deposited {amount} in A/C {AC.AccountNumber}");
                Console.WriteLine($"Total balance:{AC.Balance}");
            }
            else
            {
                Console.WriteLine("Encountered an error  while execution!!!");
            }
        }

        //withdraw money 
        public void WithdrawMoney()
        {
            Console.WriteLine("----Withdraw Money----");
            Account AC = depositamount.checkAccount();
            if (AC != null)
            {
                int amt;
                depositamount.checkPIN();
                Console.Write("Enter amount to withdraw:");
                string tamt;
                tamt = Console.ReadLine();
                if (int.TryParse(tamt, out amt))
                {
                    if (amt <= 0)
                    {
                        Console.WriteLine("Amount cant be negative");
                    }
                    else if (amt > AC.Balance)
                    {
                        Console.WriteLine("Insufficient Balance!!!");
                    }
                    else
                    {
                        AC.Balance -= amt;
                        Console.WriteLine($"Amount Withdrawn:{amt}");
                        Console.WriteLine($"Clear balance:{AC.Balance}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!!!");
                }
            }
            else
            {
                Console.WriteLine("Encountered an error  while execution!!!");

            }

        }

        //check balance 
        public void CheckBalance()
        {
            Console.WriteLine("----Check Balance----");
            Account AC = depositamount.checkAccount();
            if (AC != null)
            {
                depositamount.checkPIN();
                Console.WriteLine($"Account Holder:{AC.HolderName}");
                Console.WriteLine($"Current Balance:{AC.Balance}");
            }
            else
            {
                Console.WriteLine("Encountered an error  while execution!!!");
            }


        }

        //account details
        public void AccountDetails()
        {
            Console.WriteLine("----Account Details----");
            Account AC = depositamount.checkAccount();
            if (AC != null)
            {
                depositamount.checkPIN();
                Console.WriteLine($"A/c no.:{AC.AccountNumber}\nAccount Holder:{AC.HolderName}\nA/c type:{AC.Accounttype}\nClear balance:{AC.Balance}");
            }
            else
            {
                Console.WriteLine("Encountered an error  while execution!!!");
            }

        }

        //all accounts list
        public void ListAccounts()
        {
            Console.WriteLine("----Account list----");
            foreach (var item in allAccount)
            {
                Console.WriteLine($"A/c no:{item.AccountNumber}\nA/c Holder:{item.HolderName}\nA/c type:{item.Accounttype}\nBalance:{item.Balance}\n ");
            }
        }
    }
}