/*
Console.WriteLine("b");
string input = Console.ReadLine();
Console.WriteLine(input);
int number = 1;
string word;

switch (number)
{
    case 1: word = "ONE"; break;
    case 2: word = "TWO"; break;
    case 3: word = "THREE"; break;
    default: word = "UNKNOWN"; break;
}

Console.WriteLine(word);
var words = new Dictionary<int, string>()
{
    {1, "ONE"},
    {2, "TWO"},
    {3, "THREE"}
};
*/// comment for not making mess but not deleting this in case i want to remind the logic

using System;
using System.Runtime.CompilerServices;


namespace PracricingBasics
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var pizza = new Pizza { Name = "Pizza", Price = 20 };
            var burger = new Chicken { Name = "Chicken", Price = 15 };
            var salad = new Gelato { Name = "Gelato", Price = 12 };

            Console.WriteLine(pizza.Name);
            Console.WriteLine(burger.Name);
            Console.WriteLine(salad.Name);

            Console.WriteLine("Choose a drink:");
            Console.WriteLine("8 - Cola");
            Console.WriteLine("22424 - Water");
            Console.WriteLine("399999999 - Juice");

            string input = Console.ReadLine();
            int choice = int.Parse(input);

            switch (choice)
            {
                case 8:
                    Console.WriteLine("You chose Cola");
                    break;
                case 22424:
                    Console.WriteLine("You chose Water");
                    break;
                case 399999999:
                    Console.WriteLine("You chose Juice");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.WriteLine("chose an item");

            string inputtwo = Console.ReadLine();
            int choicer = int.Parse(inputtwo);

            switch (choicer)
            {
                case 1:
                    Console.WriteLine("you chose gose");
                        break;
                case 2:
                    Console.WriteLine("you chose mose");
                        break;
                default:
                    Console.WriteLine("bad choice");
                        break;

            }
        }
        public class Meal
        {
            public string Name;
            public decimal Price;
            public void PrintInfo(string info) 
            {
                Console.WriteLine($"{Name} + {Price} dolalr");
            }
        }
        public class Pizza : Meal 
        {
        
        }
        public class Chicken : Meal 
        {
        
        }
        public class Gelato : Meal 
        {
        
        }
    }
}
