using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Report your grade percentage");

        string percentage = Console.ReadLine();

        int number = int.Parse(percentage);

        string letter = "";

        if (number > 89)
        {
            letter ="A";
        }
        else if (number > 79)
        {
            letter ="B";
        }
        else if (number > 69)
        {
            letter ="C";
        }
        else if (number > 59)
        {
            letter ="D";
        }
        else 
        {
            letter ="F";
        }

            Console.WriteLine(letter);
        
        if (number > 70)
        {
            Console.WriteLine("Congrats, you passed the course");

        }
        else
        {
            Console.WriteLine("Not this time, try again, you can do it!");
        }








    }
}