using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int quitKey = -1;

        while (quitKey != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userImput = Console.ReadLine();
            quitKey = int.Parse(userImput);

            if (quitKey != 0)
            {
                numbers.Add(quitKey);
            }
        }

        // 1
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"the sum is: {sum}");

        // 2
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        // 3
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum is {max}");
    }
}