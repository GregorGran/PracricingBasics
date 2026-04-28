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

namespace PracricingBasics
{
    public static class Program
    {
        private static void Main(string[] args)
        {
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
        }
    }
}