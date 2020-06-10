using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Unicode;

namespace Hangit.App
{
    class Program
    {
        public static string finalWord = "GODFATHER";
        static void Main(string[] args)
        {
            //Console.OutputEncoding;
            //Console.InputEncoding;
            //UTF8Encoding utf8 = new UTF8Encoding();

            HashSet<char> guessedCharacters = new HashSet<char>();
            int guessesLeft = 10;
            char[] secretWord = new char[finalWord.Length];
            
            do
            {
                Console.WriteLine();
                Console.WriteLine(MaskedSecretWord(finalWord, guessedCharacters));
                Console.WriteLine(string.Join(' ', guessedCharacters));
                Console.WriteLine($"Guesses left: {guessesLeft}");
                Console.Write("Your guess: ");
                string ans = Console.ReadLine().ToUpper();

                if (ValidGuess(ans))
                {
                    if (guessedCharacters.Contains(ans[0]))
                    {
                        Console.WriteLine($"You have already guessed '{ans[0]}'");
                        continue;
                    } else if (finalWord.Contains(ans))
                    {
                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct\n");
                        Console.ForegroundColor = ConsoleColor.White;

                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        guessesLeft--;
                    }
                    guessedCharacters.Add(ans[0]);

                }
                else
                {
                    Console.WriteLine("Invalid guess");
                }

                

            } while (guessesLeft>0 || (new string(secretWord) == finalWord));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(":'######::::::'###::::'##::::'##:'########::::::::'#######::'##::::'##:'########:'########:::::");
            Console.WriteLine("'##... ##::::'## ##::: ###::'###: ##.....::::::::'##.... ##: ##:::: ##: ##.....:: ##.... ##::::");
            Console.WriteLine(" ##:::..::::'##:. ##:: ####'####: ##::::::::::::: ##:::: ##: ##:::: ##: ##::::::: ##:::: ##::::");
            Console.WriteLine(" ##::'####:'##:::. ##: ## ### ##: ######::::::::: ##:::: ##: ##:::: ##: ######::: ########:::::");
            Console.WriteLine(" ##::: ##:: #########: ##. #: ##: ##...:::::::::: ##:::: ##:. ##:: ##:: ##...:::: ##.. ##::::::");
            Console.WriteLine(" ##::: ##:: ##.... ##: ##:.:: ##: ##::::::::::::: ##:::: ##::. ## ##::: ##::::::: ##::. ##:::::");
            Console.WriteLine(". ######::: ##:::: ##: ##:::: ##: ########:::::::. #######::::. ###:::: ########: ##:::. ##::::");
            Console.WriteLine(":......::::..:::::..::..:::::..::........:::::::::.......::::::...:::::........::..:::::..:::::");
            Console.ResetColor();
        }

        private static string MaskedSecretWord(string finalWord, HashSet<Char> guessedCharacter)
        {
            var result = new StringBuilder();
            foreach (char c in finalWord)
            {
                if (guessedCharacter.Contains(c))
                {
                    result.Append(c);
                } else
                {
                    result.Append('-');
                }

            }

            return result.ToString();

            //for (int i = 0; i < secretWord.Length; i++)
            //{
            //    if (secretWord[i] == ans[0])
            //    {
            //        secretWord[i] = ans[0];
            //    }
            //    else if (secretWord[i] == 0)
            //    {
            //        secretWord[i] = '-';
            //    }
            //}
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
