using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_CleanCode.Player;

namespace Labb_CleanCode.BullsAndCows
{
    public class BullsAndCowsGame
    {
        public string GameName = "Bulls and Cows";
        public void PlayBullsAndCows()
        {
            Console.Clear();
            Console.WriteLine("Enter your user name:\n");
            string playerName = Console.ReadLine();

            while (true)
            {
                string numberToGuess = GenerateNumberToGuess();


                Console.WriteLine("New game:\n");
                //comment out or remove next line to play real games!
                Console.WriteLine("For practice, number is: " + numberToGuess + "\n");
                string currentUserGuess = Console.ReadLine();

                int numberOfGuesses = 1;
                string bbcc = CheckPlayerGuess(numberToGuess, currentUserGuess);
                Console.WriteLine(bbcc + "\n");
                while (bbcc != "BBBB,")
                {
                    numberOfGuesses++;
                    currentUserGuess = Console.ReadLine();
                    Console.WriteLine(currentUserGuess + "\n");
                    bbcc = CheckPlayerGuess(numberToGuess, currentUserGuess);
                    Console.WriteLine(bbcc + "\n");
                }
                Highscores.AddHighscore(GameName, playerName, numberOfGuesses);
                Highscores.ShowHighscores(GameName);
                Console.WriteLine("Correct, it took " + numberOfGuesses + " guesses\nContinue?");
                string answer = Console.ReadLine();
                if (answer != null && answer != "" && answer.Substring(0, 1) == "n")
                {
                    return;
                }
            }
        }

        public string GenerateNumberToGuess()
        {
            Random numberGenerator = new Random();
            string numberToGuess = "";
            for (int i = 0; i < 4; i++)
            {
                int randomNumber = numberGenerator.Next(10);
                string randomDigit = "" + randomNumber;
                while (numberToGuess.Contains(randomDigit))
                {
                    randomNumber = numberGenerator.Next(10);
                    randomDigit = "" + randomNumber;
                }
                numberToGuess = numberToGuess + randomDigit;
            }
            return numberToGuess;
        }

        public string CheckPlayerGuess(string numberToGuess, string playerGuess)
        {
            int cows = 0, bulls = 0;
            playerGuess += "    ";     // if player entered less than 4 chars
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (numberToGuess[i] == playerGuess[j])
                    {
                        if (i == j)
                        {
                            bulls++;
                        }
                        else
                        {
                            cows++;
                        }
                    }
                }
            }
            return "BBBB".Substring(0, bulls) + "," + "CCCC".Substring(0, cows);
        }
    }
}
