using System;

class Program
{
    static void Main(string[] args)
    {
        // 1
        DisplayWelcome();
        // 2
        string userName = PromptUserName();
        // 3
        int userNumber = PromptUserNumber();
        // 4
        int squaredNumber = SquareNumber(userNumber);
        // 5
        DisplayResult(userName, squaredNumber);


    }
        
    static void DisplayWelcome()
    {
            Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter favorite number: ");
        int name = int.Parse(Console.ReadLine());
        return name;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}