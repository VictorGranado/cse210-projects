using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.WriteLine("What is the magic number?");
        // string magicNumber = Console.ReadLine();
        // int number = int.Parse(magicNumber);

        int guess = 0;

        Console.WriteLine("What is your guess?");
        // string guessNumber = Console.ReadLine();
        // int guess = int.Parse(guessNumber);

        while (guess != number)
        {
           guess = Convert.ToInt32(Console.ReadLine());

           if (guess < number)
           {
            Console.WriteLine("Higher");
           }

           else if (guess > number)
           {
            Console.WriteLine("Lower");
           }
        }
        Console.WriteLine("You guessed it!");
        Console.ReadLine();
        

    }
}