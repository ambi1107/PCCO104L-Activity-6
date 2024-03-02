using System;
using System.Collections.Generic;

class Program
{
    static void Activity1()
    {
        Dictionary<double, string> denominations = new Dictionary<double, string>()
        {
            { 0.01, "No Person is found" },
            { 0.05, "No Person is found" },
            { 0.25, "No Person is found" },
            { 1, "Jose Rizal" },
            { 5, "Emilio Aguinaldo" },
            { 10, "Andres Bonifacio, Apolinario Mabini" },
            { 20, "Manuel L. Quezon" },
            { 50, "Sergio Osmena" },
            { 100, "Manuel Roxas" },
            { 200, "Diosdado Macapagal" },
            { 500, "Benigno Sr. and Corazon Aquino" },
            { 1000, "Jose Abad Santos, Vicente Lim, Josefa Llanes Escoda" }
        };

        Console.WriteLine("\nActivity 1 - PH Money Denomination");
        while (true)
        {
            Console.Write("Enter value in Philippine Peso: ");
            string valueStr = Console.ReadLine();
            if (valueStr.ToLower() == "exit")
            {
                Console.WriteLine("Closing Program...");
                break;
            }
            try
            {
                double amount = double.Parse(valueStr);
                if (denominations.ContainsKey(amount))
                {
                    Console.WriteLine($"{amount} - {denominations[amount]}");
                }
                else
                {
                    Console.WriteLine($"Invalid Denomination: {amount}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }

    static void Activity2()
    {
        Console.WriteLine("\nActivity 2 - Number Divisibility");
        while (true)
        {
            Console.Write("Enter value: ");
            string value = Console.ReadLine();
            if (value.ToLower() == "exit")
            {
                Console.WriteLine("Closing Program...");
                break;
            }
            try
            {
                int number = int.Parse(value);
                for (int i = 1; i <= number; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        Console.WriteLine($"{i} - FooBar");
                    else if (i % 3 == 0)
                        Console.WriteLine($"{i} - Foo");
                    else if (i % 5 == 0)
                        Console.WriteLine($"{i} - Bar");
                    else
                        Console.WriteLine(i);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }

    static void Activity3()
    {
        Console.WriteLine("\nActivity 3 - Input Message");
        string message = "";
        while (true)
        {
            Console.Write("Enter something: ");
            string value = Console.ReadLine();
            if (value.ToLower() == "exit")
            {
                Console.WriteLine("Closing Program...");
                break;
            }
            else
            {
                message += value + " ";
                Console.WriteLine(message.Trim());
            }
        }
    }

    static void Activity4()
    {
        Console.WriteLine("\nActivity 4 - Build Pyramid");
        while (true)
        {
            Console.Write("Enter a number to build pyramid: ");
            string value = Console.ReadLine();
            if (value == "0")
            {
                Console.WriteLine("Closing Program...");
                break;
            }
            try
            {
                int number = int.Parse(value);
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(new string(' ', number - i - 1) + new string('*', 2 * i + 1));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }

    static void Activity5()
    {
        Console.WriteLine("\nActivity 5 - Sum vs. Append");
        int currentSum = 0;
        string currentMessage = "";
        while (true)
        {
            Console.Write("Enter something: ");
            string value = Console.ReadLine();
            if (value.ToLower() == "exit")
            {
                Console.WriteLine("Closing Program...");
                break;
            }
            try
            {
                int num = int.Parse(value);
                currentSum += num;
                Console.WriteLine($"Adding {num} to {currentSum - num} = {currentSum}");
            }
            catch (FormatException)
            {
                currentMessage += value + " ";
                Console.WriteLine($"Current Message is: {currentMessage.Trim()}");
            }
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nSelect Activity from 1 - 5.");
            Console.Write("Activity: ");
            string activity = Console.ReadLine();

            switch (activity)
            {
                case "1":
                    Activity1();
                    break;
                case "2":
                    Activity2();
                    break;
                case "3":
                    Activity3();
                    break;
                case "4":
                    Activity4();
                    break;
                case "5":
                    Activity5();
                    break;
                case "exit":
                    Console.WriteLine("Closing Program...");
                    return;
                default:
                    Console.WriteLine("Activity does not exist.");
                    break;
            }
        }
    }
}  