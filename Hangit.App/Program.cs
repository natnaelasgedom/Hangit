using System;
using System.Text.RegularExpressions;

namespace Hangit.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "GODFATHER";
            do
            {
                Console.WriteLine("Your guess: ");
                string ans = Console.ReadLine();
                Console.WriteLine($"Your guess: {ans}");

                if (!ValidGuess(ans))
                {
                    Console.WriteLine("Invalid guess");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (RightCharacter(ans))
                {
                    Console.WriteLine("Correct");
                    Console.ReadLine();
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine("Wrong");
                    Console.ReadLine();
                    Console.Clear();

                }
            } while (true);
            
            
            
            
            
        }

        public static bool ValidGuess(string userGuess)
        {
            return Regex.IsMatch(userGuess.ToUpper(), "^[A-ZÆØÅ]$");
        }

        public static bool RightCharacter(string userGuess)
        {
            return Regex.IsMatch(userGuess.ToUpper(), "^[GODFATHER]$");
        }

        
    }
}
