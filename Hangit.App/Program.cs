using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Unicode;

namespace Hangit.App
{
    class Program
    {
        public static string secretWord = "GODFATHER";
        static void Main(string[] args)
        {
            //Console.OutputEncoding;
            //Console.InputEncoding;
            //UTF8Encoding utf8 = new UTF8Encoding();

            HashSet<char> guessedCharacters = new HashSet<char>();
            int guessesLeft = 10;
            do
            {
                Console.WriteLine();
                Console.WriteLine(string.Join(' ', guessedCharacters));
                Console.WriteLine($"Guesses left: {guessesLeft}");
                Console.Write("Your guess: ");
                string ans = Console.ReadLine().ToUpper();
                
                if (ValidGuess(ans))
                {
                    guessedCharacters.Add(ans[0]);
                    
                    if (secretWord.Contains(ans))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct\n");
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
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
