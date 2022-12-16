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
            BullsAndCowsController controller = new BullsAndCowsController();

            while (true)
            {
                string numberToGuess = controller.GenerateNumberToGuess();


                Console.WriteLine("New game:\n");
                //comment out or remove next line to play real games!
                Console.WriteLine("For practice, number is: " + numberToGuess + "\n");
                string currentUserGuess = Console.ReadLine();

                int numberOfGuesses = 1;
                string bbcc = controller.CheckPlayerGuess(numberToGuess, currentUserGuess);
                Console.WriteLine(bbcc + "\n");
                while (bbcc != "BBBB,")
                {
                    numberOfGuesses++;
                    currentUserGuess = Console.ReadLine();
                    Console.WriteLine(currentUserGuess + "\n");
                    bbcc = controller.CheckPlayerGuess(numberToGuess, currentUserGuess);
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
       
    }
}
