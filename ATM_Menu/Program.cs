using System;
using System.Collections;

namespace ATM_Menu
{
    public class BankDetails
    {
        public int AC_Num { get; set; }
        public string name { get; set; }
        public int balance { get; set; }
    }
    public class Program {
        public static void checkBalance(int acNum, Hashtable bank)
        {
            
            int balance = 0;
            if (bank.Contains(acNum))
            {
                foreach (DictionaryEntry i in bank)
                {
                    BankDetails details = (BankDetails)i.Value;

                    if (i.Key.Equals(acNum))
                    {
                        balance = details.balance;
                        break;
                    }
                }

                Console.WriteLine("Your Account Balance : " + balance);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Account Not Found :(");
                Console.ResetColor();
            }   
        }

        public static void moneyDeposit(int acNum, int dMoney, Hashtable bank)
        {
            if(bank.Contains(acNum))
            {

                BankDetails details = (BankDetails) bank[acNum];
                details.balance += dMoney;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("||     ~~~~~~    Bill for the Money Deposit     ~~~~~~    ||");
                Console.WriteLine("------------------------------------------------------------");
                Console.ResetColor();

                Console.WriteLine("Account Number : "+details.AC_Num);
                Console.WriteLine("Account Holder Name : "+details.name);
                Console.WriteLine("Balance : "+details.balance);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You are amount was Successfully Deposited :)");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("------------------------------------------------------------");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Account Not Found :(");
                Console.ResetColor();
            }
        }

        public static void moneyWithdraw(int acNum, int money, Hashtable bank)
        {

            BankDetails details = (BankDetails)bank[acNum];

            if (details.balance >= money)
            {
                details.balance -= money;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("||     ~~~~~~    Bill for the Money withdraw     ~~~~~~    ||");
                Console.WriteLine("------------------------------------------------------------");
                Console.ResetColor();

                Console.WriteLine("Account Number : " + details.AC_Num);
                Console.WriteLine("Account Holder Name : " + details.name);
                Console.WriteLine("Balance : " + details.balance);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You are amount was Successfully Withdraw :)");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("------------------------------------------------------------");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Insuffient Bank Balance :(");
                Console.ResetColor();
            }
           
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================= ATM Menu =========================");
            Console.WriteLine("||                           ||                           ||");
            Console.WriteLine("------------------------------------------------------------");
            Console.ResetColor();

            Console.WriteLine("                    Choose the Operations                   ");
            Console.WriteLine("                    1. Check Balance                        ");
            Console.WriteLine("                    2. Deposit                              ");
            Console.WriteLine("                    3. Withdraw                             ");
            Console.WriteLine("                    4. Exist                                ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------------------------------------------");
            Console.ResetColor();

            Hashtable bank = new Hashtable()
            {
                {2041, new BankDetails{AC_Num= 2041, name = "Thamizh", balance = 60000} },
                {2065, new BankDetails{AC_Num= 2065, name = "Sharmila", balance = 70000} },
                {4034, new BankDetails{AC_Num= 4034, name = "Subha", balance = 90000} },
                {5621, new BankDetails{AC_Num= 5621, name = "Sabari", balance = 50000} }
            };

           
            

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter the Choice : ");
                Console.ResetColor();
                int choice = int.Parse(Console.ReadLine());
                if (choice == 4)
                {
                    Console.WriteLine("Thank You !!");
                    Console.ReadLine();
                    break;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You Enter 1 for Check the Bank Balance");
                        Console.Write("Enter the Account Number A/C: ");
                        int acNum = int.Parse(Console.ReadLine());
                        checkBalance(acNum, bank);

                        break;

                    case 2:
                        Console.WriteLine("You Enter 2 for Deposit the Money in Bank");

                        Console.Write("Enter the Account Number: ");
                        int acNum1 = int.Parse(Console.ReadLine());

                        if (bank.ContainsKey(acNum1))
                        {
                            Console.Write("Enter the Amount for Deposit : ");
                            int dMoney = int.Parse(Console.ReadLine());

                            moneyDeposit(acNum1, dMoney, bank);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Account Not Found :(");
                            Console.ResetColor();
                        }
                        break;

                    case 3:
                        Console.WriteLine("You Enter 3 for Withdraw the Money from Bank");

                        Console.Write("Enter the Account Number: ");
                        int acNum2 = int.Parse(Console.ReadLine());

                        if (bank.ContainsKey(acNum2))
                        {
                            Console.Write("Enter the Amount for the Withdraw: ");
                            int wMoney = int.Parse(Console.ReadLine());
                            moneyWithdraw(acNum2, wMoney, bank);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Account Not Found :(");
                            Console.ResetColor();
                        }

                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please make a correct choice. :(");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}