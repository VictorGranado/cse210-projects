using System;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            Loader loader = new Loader("dictionary.csv");

            string randomScripture = loader.FindRandomScripture();
            Console.WriteLine(randomScripture);

        }
    }
}