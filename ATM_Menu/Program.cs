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
                Console.WriteLine("Account Not Found");
                Console.ResetColor();
            }   
        }

        public static void moneyDeposit(int acNum, int dMoney, Hashtable bank)
        {
            if(bank.Contains(acNum))
            {
                foreach(DictionaryEntry i in bank)
                {
                    BankDetails details = (BankDetails)i.Value;

                    if (i.Key.Equals(acNum))
                    {
                        bank[i.Key] = details.balance + dMoney;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Successfully Deposited :)");
                        Console.ResetColor();
                        Console.WriteLine(" Bank Balance: A/C :"+details.AC_Num+" : Name: "+ details.name +"Balance : "+details.balance);
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Account Not Found");
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
                {4034, new BankDetails{AC_Num= 4034, name = "Subha", balance = 90000}  },
                {5621, new BankDetails{AC_Num= 5621, name = "Sabari", balance = 50000}  }
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

                        Console.WriteLine("Enter the Amount for Deposit");
                        int dMoney = int.Parse(Console.ReadLine());

                        moneyDeposit(acNum1, dMoney, bank);

                        break;

                }
            }
        }
    }
}