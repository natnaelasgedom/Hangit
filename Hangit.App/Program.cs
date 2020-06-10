using System;

namespace Hangit.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "GODFATHER";
            Console.WriteLine("Your guess: ");
            string ans = Console.ReadLine().ToUpper();
            Console.WriteLine("You guessed: " + ans);
            Console.WriteLine("\nGame over!");
        }
    }
}
