using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_CleanCode
{
    public class HangmanGame
    {
        public string[] Words = { "deliver", "recognise", "regain", "supervise", "consider", "stop", "submit", "plan", "forget", "break" };
        public string? WordToGuess;
        public char[]? HiddenWord;
        public List<char> GuessedLetters = new List<char>();
        public int WrongGuesses = 0;
        public string GameName = "Hangman";


        public void PlayHangman()
        {
            Console.Clear();
            Console.WriteLine("\tWelcome to hangman, you have 7 guesses to get the word right!");
            Console.WriteLine("\tEnter your user name:\n");
            string playerName = Console.ReadLine();
            GetRandomWord();

            while (true)
            {
                HangmanCharacter.TheHangman(WrongGuesses);
                Console.Write("\n\t");
                foreach (var character in HiddenWord)
                {
                    Console.Write(character + " ");
                }
                Console.Write("\n\n\tGuessed letters: ");
                foreach(var letter in GuessedLetters)
                {
                    Console.Write(letter);
                }
                Console.Write("\n\tYour guess: ");
                string userGuess = Console.ReadLine().ToLower();
                CheckIfGuessIsCorrect(userGuess);
                bool lettersStillHidden = CheckWin();
                if (!lettersStillHidden)
                {
                    Console.WriteLine("\tCongratulations you guessed the word!");
                    Highscores.AddHighscore(GameName, playerName, WrongGuesses);
                    Highscores.ShowHighscores(GameName);
                    Console.WriteLine("\tPress any key to go back to the main meny");
                    GuessedLetters.Clear();
                    WrongGuesses = 0;
                    Console.ReadLine();
                    return;
                }
                if(WrongGuesses >= 7)
                {
                    HangmanCharacter.TheHangman(WrongGuesses);
                    GameOver();
                    Console.WriteLine("\tYou are out of guesses, the word was {0}", WordToGuess);
                    Console.WriteLine("\tPress any key to go back to the main meny");
                    GuessedLetters.Clear();
                    WrongGuesses = 0;
                    Console.ReadLine();
                    return;     
                }
            }
        }

        private bool CheckWin()
        {
            return HiddenWord.Contains('_');
        }

        private void CheckIfGuessIsCorrect(string userGuess)
        {
            bool rightGuess = false;
            if(char.TryParse(userGuess, out char guess) && char.IsLetter(guess))
            {
                if (GuessedLetters.Contains(guess))
                {
                    Console.WriteLine("\tYou have already guessed on that letter, guess again");
                }
                else
                {
                    for (int i = 0; i < WordToGuess.Length; i++)
                    {
                        if (WordToGuess[i] == guess)
                        {
                            HiddenWord[i] = guess;
                            GuessedLetters.Add(guess);
                            rightGuess = true;
                        }
                    }
                    if(!rightGuess)
                    {
                        GuessedLetters.Add(guess);
                        WrongGuesses++;
                    }
                }
            }
            else
            {
                Console.WriteLine("\tYou can only guess with single letters. Try again!");
            }
            Console.Clear();
        }

        private void CheckForCorrectInput(string userGuess)
        {
            throw new NotImplementedException();
        }

        private void GetRandomWord()
        {
            Random randomGenerator = new Random();
            WordToGuess = Words[randomGenerator.Next(Words.Length)];
            HiddenWord = WordToGuess.ToCharArray();
            for(int i = 0; i < HiddenWord.Length; i++)
            {
                HiddenWord[i] = '_';
            }
        }

        private void GameOver()
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
