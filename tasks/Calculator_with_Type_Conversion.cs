using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text.Json.Serialization.Metadata;
using System.Transactions;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace taks
{
    public class Calculator_with_Type_Conversion
    {
        public static void Calculator()
        {
            //Exercise: Calculator with Type Conversion
            //Write a program that:

            //Accepts two strings from the user.

            //Tries to convert them into int or double.

            //Performs addition, subtraction, multiplication, division using appropriate operators.

            //Uses Convert and TryParse methods.

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------- Calculator  -----------------------");
            Console.WriteLine("||     ||    ||     ||    ||     ||     ||    ||     ||    ||");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Console.WriteLine("Choose the Operator to Perform Operation");
            Console.WriteLine(" '+' - Addition ");
            Console.WriteLine(" '-' - Subtration ");
            Console.WriteLine(" '*' - Multiplication ");
            Console.WriteLine(" '/' - Division");
            Console.WriteLine(" '%' - Modulus");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Console.WriteLine("Enter the two Number for Calculation");


            

            bool flag = true;
            while (flag) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter Number 1: ");
                Console.ResetColor();
                int num1 = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter Number 2: ");
                Console.ResetColor();
                int num2 = int.Parse(Console.ReadLine());

                double dNum1 = num1;
                double dNum2 = num2;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter the Operator : ");
                string operators = Console.ReadLine();
                Console.ResetColor();

                switch (operators)
                {
                    case "+":
                        double result1 = dNum1 + dNum2;
                        Console.WriteLine($"Result : {num1} + {num2} = {result1}");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("If you wnat to Perform Operation: (y/n)");
                        Console.ResetColor();

                        char ch1= char.Parse(Console.ReadLine());
                        if(ch1== 'n')
                        {
                            Console.WriteLine("Thank You !!");
                            flag = false;   
                        }
                        break;

                    case "-":
                        double result2= dNum1 -dNum2;
                        Console.WriteLine($"Result : {num1} -{num2} = {result2}");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("If you wnat to Perform Operation: (y/n)");
                        Console.ResetColor();

                        char ch2= char.Parse(Console.ReadLine());
                        if (ch2== 'n')
                        {
                            Console.WriteLine("Thank You !!");
                            flag = false;
                        }
                        break;

                    case "*":
                        double result3= dNum1 *dNum2;
                        Console.WriteLine($"Result : {num1} *{num2} = {result3}");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("If you wnat to Perform Operation: (y/n)");
                        Console.ResetColor();

                        char ch3= char.Parse(Console.ReadLine());
                        if (ch3== 'n')
                        {
                            Console.WriteLine("Thank You !!");
                            flag = false;
                        }
                        break;

                    case "/":
                        double result4= dNum1 /dNum2;
                        Console.WriteLine($"Result : {num1} /{num2} = {result4}");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("If you wnat to Perform Operation: (y/n)");
                        Console.ResetColor();

                        char ch4= char.Parse(Console.ReadLine());
                        if (ch4== 'n')
                        {
                            Console.WriteLine("Thank You !!");
                            flag = false;
                        }
                        break;

                    case "%":
                        double result5= dNum1 %dNum2;
                        Console.WriteLine($"Result : {num1} %{num2} = {result5}");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("If you wnat to Perform Operation: (y/n) :");
                        Console.ResetColor();

                        char ch5= char.Parse(Console.ReadLine());
                        if (ch5== 'n')
                        {
                            Console.WriteLine("Thank You !!");
                            flag = false;
                        }
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You are Entered Worng Operator");
                        break;
                }
            }   
        }
        //Exercise: Find Second Largest Number

        //Read 10 integers from the user into an array.

        //Loop through the array to find and print the second largest unique number.

        //Do not use built -in sorting methods.
        public static void SecondLargesNumber()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------ Find Second Largest Number-----------------");
            Console.WriteLine("||     ||    ||     ||    ||     ||     ||    ||     ||     ||");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ResetColor();

            int[] arr = new int[10];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the 10 Array Elements: ");
            Console.ResetColor();

            for(int i =0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); 
            }

            int max = arr[0];
            int secondMax = 0;

            foreach(int i in arr)
            {
                int currentmax = max;
                if(i > max)
                {
                    max = i;
                    secondMax = currentmax;
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------ Find Second Largest Number-----------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The Second Lasted Number in the Array is "+secondMax);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------ Find Second Largest Number-----------------");
            Console.ResetColor();
        }

        public static void MiniSuperMarket()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------ Grovery Bill Calculator ------------------");
            Console.WriteLine("||     ||    ||     ||    ||     ||     ||    ||     ||    ||");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Console.WriteLine("              Choose the Items for purchasing                 ");
            Console.WriteLine("              101. Milk              - Rs.20                  ");
            Console.WriteLine("              102. Coconut Oil       - Rs.50                  ");
            Console.WriteLine("              103. Sugar             - Rs.15                  ");
            Console.WriteLine("              104. Salt              - Rs.20                  ");
            Console.WriteLine("              105. Rice              - Rs.50                  ");
            Console.WriteLine("              106. Butter            - Rs.30                  ");

            Console.WriteLine("                    For Billing Press '1'                  ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Dictionary<int, int> itemsPrice = new Dictionary<int, int>();
            itemsPrice.Add(101, 20);
            itemsPrice.Add(102, 50);
            itemsPrice.Add(103, 15);
            itemsPrice.Add(104, 20);
            itemsPrice.Add(105, 50);
            itemsPrice.Add(106, 30);

            Dictionary<int, string> itemsName = new Dictionary<int, string>()
            {
                {101, "Milk" },
                {102, "Coconut Oil" },
                {103, "Sugar" },
                {104, "Salt" },
                {105, "Rice" },
                {106,"Butter" }
            };

            Dictionary<string, int> produts = new Dictionary<string, int>();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Here You can Enter the code of Items for purchasing");
            Console.ResetColor();

            int quantity = 0;
            int total = 0;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter the Item Code / Proceed Bill Enter '1': ");
                Console.ResetColor();

                int code = int.Parse(Console.ReadLine());   

                if(code == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Thank You For Purchasing");
                    Console.ResetColor();
                    break;
                }

                switch (code)
                {
                    case 101:
                        quantity += 1;
                        Console.Write($"Enter the Quantity of {itemsName[code]} : ");
                        int quantity1 = int.Parse(Console.ReadLine());
                        int totalPrice1 = itemsPrice[code] * quantity1;
                        total += totalPrice1;
                        produts.Add(itemsName[code], totalPrice1);
                        break;

                    case 102:
                        quantity += 1;
                        Console.Write($"Enter the Quantity of {itemsName[code]} : ");
                        int quantity2 = int.Parse(Console.ReadLine());
                        int totalPrice2 = itemsPrice[code] * quantity2;
                        total += totalPrice2;
                        produts.Add(itemsName[code], totalPrice2);
                        break;  

                    case 103:
                        quantity += 1;
                        Console.Write($"Enter the Quantity of {itemsName[code]} : ");
                        int quantity3 = int.Parse(Console.ReadLine());
                        int totalPrice3 = itemsPrice[code] * quantity3;
                        total += totalPrice3;
                        produts.Add(itemsName[code], totalPrice3);
                        break;

                    case 104:
                        quantity += 1;
                        Console.Write($"Enter the Quantity of {itemsName[code]} : ");
                        int quantity4 = int.Parse(Console.ReadLine());
                        int totalPrice4 = itemsPrice[code] * quantity4;
                        total += totalPrice4;
                        produts.Add(itemsName[code], totalPrice4);
                        break;

                    case 105:
                        quantity += 1;
                        Console.Write($"Enter the Quantity of {itemsName[code]} : ");
                        int quantity5 = int.Parse(Console.ReadLine());
                        int totalPrice5 = itemsPrice[code] * quantity5;
                        total += totalPrice5;
                        produts.Add(itemsName[code], totalPrice5);
                        break;

                    case 106:
                        quantity += 1;
                        Console.Write($"Enter the Quantity of {itemsName[code]} : ");
                        int quantity6 = int.Parse(Console.ReadLine());
                        int totalPrice6 = itemsPrice[code] * quantity6;
                        total += totalPrice6;
                        produts.Add(itemsName[code], totalPrice6);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You Entered Worng Item Code");
                        Console.ResetColor();
                        break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("Purchased Items");
            Console.WriteLine("\tItems\t\tQuantity Cost");
            foreach (KeyValuePair<string, int> i in produts)
            {
                Console.WriteLine($"\t{i.Key}\t\t{i.Value}");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------------Total Quantity - " + quantity + "---------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------- Total Amount - " + (decimal)total + " -----------------------");
            Console.ResetColor();
        }

        public static void SafeNumber()
        {
            List<int> list = new List<int>();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------- Safe Number Collector -------------------");
            Console.WriteLine("||  ~  ||    ||    ||    ||   ~   ||    ||    ||     || ~  ||");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Console.WriteLine("           Enter 'exit' for Stoping the Iteration            ");
         

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("              Safe Number Colleter is Started                ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the Elements Here");
            Console.ResetColor();

            List<int> l = new List<int>();

            while (true) {
                
                string input = Console.ReadLine();

                if(input == "exit")
                {
                    break;
                }

                bool success = int.TryParse(input, out int number);

                if (success)
                {
                    l.Add(number);
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Displaying the valid Integers Collections");
            Console.ResetColor();

            
            foreach(int i in l)
            {
                Console.Write(i + " ");
            }
        }







        
        static void Main(string[] args)
        {
            //Calculator();
            //SecondLargesNumber();
            //MiniSuperMarket();
            SafeNumber();
        }

        public class BankDetails
        {
            public int AC_Num { get; set; }
            public string name { get; set; }
            public int balance { get; set; }
        }
    }
}