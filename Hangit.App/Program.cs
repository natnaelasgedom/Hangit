using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Hangit.App
{
    class Program
    {
        public static string secretWord = "GODFATHER";
        static void Main(string[] args)
        {
            //List<char> guessedCharacters = new List<char>();
            int guessesLeft = 10;
            do
            {
                Console.WriteLine();
                Console.WriteLine($"Guesses left: {guessesLeft}");
                Console.Write("Your guess: ");
                string ans = Console.ReadLine();
                Console.WriteLine($"Your guess: {ans}");
                guessesLeft--;
                if (ValidGuess(ans))
                {
                    if (secretWord.Contains(ans))
                    {
                        Console.WriteLine("Correct");
                    }
                    
                    else
                    {
                        Console.WriteLine("Wrong");
                        //guessedCharacters.Add(ans[0]);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid guess");
                }

            } while (true && guessesLeft>0);
            Console.WriteLine("GAME OVER");
            
            
            
            
            
        }

        public static bool ValidGuess(string userGuess)
        {
            return Regex.IsMatch(userGuess.ToUpper(), "^[A-ZÆØÅ]$");
        }

        public static bool RightCharacter(string userGuess)
        {
            return Regex.IsMatch(userGuess.ToUpper(), "^[+ secretWord + ]$");
        }
        
    }
}
