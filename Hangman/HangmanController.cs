using Labb_CleanCode.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_CleanCode.Hangman
{
    public class HangmanController
    {
        public string[] Words = { "deliver", "recognise", "regain", "supervise", "consider", "stop", "submit", "plan", "forget", "break" };
        public string WordToGuess = "";
        public char[] HiddenWord = {};
        public List<char> GuessedLetters = new List<char>();
        public int WrongGuesses = 0;
        public string GameName = "Hangman";

        public bool CheckWin()
        {
            return HiddenWord.Contains('_');
        }

        public void CheckUserGuess(string userGuess)
        {
            if (char.TryParse(userGuess, out char guess) && char.IsLetter(guess))
            {
                if (GuessedLetters.Contains(guess))
                {
                    Console.WriteLine("\tYou have already guessed on that letter, guess again");
                }
                else
                {
                    CheckIfLetterIsCorrect(guess);
                }
            }
            else
            {
                Console.WriteLine("\tYou can only guess with single letters. Try again!");
            }
            Console.Clear();
        }

        public void CheckIfLetterIsCorrect(char guess)
        {
            bool rightGuess = false;
            for (int i = 0; i < WordToGuess.Length; i++)
            {
                if (WordToGuess[i] == guess)
                {
                    HiddenWord[i] = guess;
                    GuessedLetters.Add(guess);
                    rightGuess = true;
                }
            }
            if (!rightGuess)
            {
                GuessedLetters.Add(guess);
                WrongGuesses++;
            }
        }
        public void GetRandomWord()
        {
            Random randomGenerator = new Random();
            WordToGuess = Words[randomGenerator.Next(Words.Length)];
            HiddenWord = WordToGuess.ToCharArray();
            for (int i = 0; i < HiddenWord.Length; i++)
            {
                HiddenWord[i] = '_';
            }
        }

        public void GameOverText()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("     GGGG                                       OOOOOO         ");
            Console.WriteLine("   GG   GG                                    OO      OO         ");
            Console.WriteLine(" GG      GG                                 OO          OO       ");
            Console.WriteLine("GGG         AAAAAAA  MMM     MMM  EEEEEEE OO              OO VV       VV EEEEEEE RRRRRRR");
            Console.WriteLine("GG          AA   AA MM MM   MM MM EE      OO              OO VV       VV EE      RR   RR");
            Console.WriteLine("GG    GGGGG AAAAAAA MM  MM MM  MM EEEEE   OO              OO  VV     VV  EEEEE   RRRRRRR");
            Console.WriteLine(" GG      GG AA   AA MM  MM MM  MM EE       OO            OO    VV   VV   EE      RRR");
            Console.WriteLine("  GGG    GG AA   AA MM   MMM   MM EE        OO          OO      VV VV    EE      RR RR");
            Console.WriteLine("   GG   GGG AA   AA MM    M    MM EE          OO      OO         VVV     EE      RR  RR");
            Console.WriteLine("     GGGG   AA   AA MM         MM EEEEEEE       OOOOOO            V      EEEEEEE RR   RR");

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
