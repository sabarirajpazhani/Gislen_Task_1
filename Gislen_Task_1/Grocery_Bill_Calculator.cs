using System;

//Exercise: Grocery Bill Calculator
//Write a program that:

//Declares variables for item name, quantity, unit price, and total.

//Calculates and prints the total bill for three different items.

//Uses appropriate data types: string, int, decimal, bool.

namespace Gislen_Task_1
{
    public class Grocery_Bill_Calculator
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------ Grovery Bill Calculator ------------------");
            Console.WriteLine("||     ||    ||     ||    ||     ||     ||    ||     ||    ||");
            Console.WriteLine("-------------------------------------------------------------"); 
            Console.ResetColor();

            Console.WriteLine("              Choose the Items for purchasing                ");
            Console.WriteLine("               1. Milk              - Rs.20                  ");
            Console.WriteLine("               2. Coconut Oil       - Rs.50                  ");
            Console.WriteLine("               3. Sugar             - Rs.15                  ");
            Console.WriteLine("               4. Salt              - Rs.20                  ");
            Console.WriteLine("               5. Rice              - Rs.50                  ");
            Console.WriteLine("               6. Butter            - Rs.30                  ");

            Console.WriteLine("                    For Billing Press '#'                    ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Dictionary<string, int> items = new Dictionary<string, int>()
            {
                {"milk", 20},
                {"coconut oil", 50},
                {"sugar", 15 },
                {"salt",20},
                {"rice", 50},
                {"butter", 30}
            };

            int quantity = 0;
            int total = 0;



            Dictionary<string, int> purchasedItems = new Dictionary<string, int>();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the Items for  Purchasing");
            Console.ResetColor();

            while (true)
            {
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "#")
                {
                    break;
                }
                switch (userInput)
                {
                    case "milk":
                        Console.Write($"Enter the {userInput} Quantity: ");
                        int quantity1 = Convert.ToInt32(Console.ReadLine());
                        quantity += 1;
                        int price1 = items[userInput] * quantity1;
                        total += price1;
                        purchasedItems.Add(userInput, price1);
                        break;

                    case "coconut oil":
                        Console.Write($"Enter the {userInput} Quantity: ");
                        int quantity2 = Convert.ToInt32(Console.ReadLine());
                        quantity += 1;
                        int price2 = items[userInput] * quantity2;
                        total += price2;
                        purchasedItems.Add(userInput, price2);
                        break;

                    case "sugar":
                        Console.Write($"Enter the {userInput} Quantity: ");
                        int quantity3 = Convert.ToInt32(Console.ReadLine());
                        quantity += 1;
                        int price3 = items[userInput] * quantity3;
                        total += price3;
                        purchasedItems.Add(userInput, price3);
                        break;

                    case "salt":
                        Console.Write($"Enter the {userInput} Quantity: ");
                        int quantity4 = Convert.ToInt32(Console.ReadLine());
                        quantity += 1;
                        int price4 = items[userInput] * quantity4;
                        total += price4;
                        purchasedItems.Add(userInput, price4);
                        break;

                    case "rice":
                        Console.Write($"Enter the {userInput} Quantity: ");
                        int quantity5 = Convert.ToInt32(Console.ReadLine());
                        quantity += 1;
                        int price5 = items[userInput] * quantity5;
                        total += price5;
                        purchasedItems.Add(userInput, price5);
                        break;

                    case "butter":
                        Console.Write($"Enter the {userInput} Quantity: ");
                        int quantity6 = Convert.ToInt32(Console.ReadLine());
                        quantity += 1;
                        int price6 = items[userInput] * quantity6;
                        total += price6;
                        purchasedItems.Add(userInput, price6);
                        break;

                    default:
                        Console.WriteLine("Items Not Found");
                        break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your Purchased Items: ");
            Console.ResetColor();

            Console.WriteLine("\tItems\t\t\t\t\tPrice");
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (KeyValuePair<string, int> i in purchasedItems)
            {
                Console.WriteLine($"\t{i.Key}\t\t\t\t\t{i.Value}");
            }
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------- Total Quantity - " + quantity + " ---------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------- Total Amount - " +(decimal)total + " -----------------------");
            Console.ResetColor();

        }
    }
}