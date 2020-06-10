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
            List<char> guessedCharacters = new List<char>();
            int guessesLeft = 10;
            do
            {
                Console.WriteLine();
                Console.WriteLine($"Guesses left: {guessesLeft}");
                Console.Write("Your guess: ");
                string ans = Console.ReadLine().ToUpper();
                
                if (ValidGuess(ans))
                {
                    if (!guessedCharacters.Contains(ans[0]))
                    {
                        guessedCharacters.Add(ans[0]);
                    }
                    if (secretWord.Contains(ans))
                    {
                        Console.WriteLine("Correct\n");
                    }
                    
                    else
                    {
                        Console.WriteLine("Wrong\n");
                        guessesLeft--;

                    }
                }
                else
                {
                    Console.WriteLine("Invalid guess");
                }

                foreach (var item in guessedCharacters)
                {
                    Console.Write(item + " ");
                }

            } while (guessesLeft>0);
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
