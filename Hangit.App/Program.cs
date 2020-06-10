using System;
using System.Text.RegularExpressions;

namespace Hangit.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "GODFATHER";
            Console.WriteLine("Your guess: ");
            string ans = Console.ReadLine();
            
            if(!ValidGuess(ans))
            {
                Console.WriteLine("Invalid choice!");
            } 
            else if (RightCharacter(ans))
            {
                Console.WriteLine($"You guessed: {ans}");
                Console.WriteLine($"You guessed a correct letter.");
                Console.WriteLine("Continue!");
            } else
            {
                Console.WriteLine($"You guessed: {ans}");
                Console.WriteLine("Wrong");
                Console.WriteLine("\nGame over!");
            }
            
            
        }

        public static bool ValidGuess(string userGuess)
        {
            return Regex.IsMatch(userGuess.ToUpper(), "^[A-ZÆØÅ]$");
        }

      
        
    }
}
