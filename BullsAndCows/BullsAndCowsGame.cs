using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_CleanCode.Interface;
using Labb_CleanCode.Player;

namespace Labb_CleanCode.BullsAndCows
{
    public class BullsAndCowsGame : IGame
    {

        public int instanceCount { get; set; } = 0;


        public BullsAndCowsGame()
        {          
            if(instanceCount > 0)
            {
                throw new Exception("More than 1 instance created");
            }
            instanceCount++;
        }
        public void PlayGame()
        {
            Console.Clear();
            InputController inputController = new InputController();
            BullsAndCowsController controller = new BullsAndCowsController();
            string playerName = inputController.CheckPlayerNameInput();

            while (true)
            {
                string numberToGuess = controller.GenerateNumberToGuess();

                Console.WriteLine("New game:\n");
                //comment out or remove next line to play real games!
                Console.WriteLine("For practice, number is: " + numberToGuess + "\n");
                string currentUserGuess = inputController.CheckGuessInput();

                int numberOfGuesses = 1;
                string bbcc = controller.CheckPlayerGuess(numberToGuess, currentUserGuess);
                Console.WriteLine(bbcc + "\n");
                while (bbcc != "BBBB,")
                {
                    numberOfGuesses++;
                    currentUserGuess = inputController.CheckGuessInput();
                    Console.WriteLine(currentUserGuess + "\n");
                    bbcc = controller.CheckPlayerGuess(numberToGuess, currentUserGuess);
                    Console.WriteLine(bbcc + "\n");
                }
                Highscores.AddHighscore(controller.GameName, playerName, numberOfGuesses);
                Highscores.ShowHighscores(controller.GameName);
                Console.WriteLine("Correct, it took " + numberOfGuesses + " guesses\nContinue?");
                string answer = Console.ReadLine() ?? string.Empty;
                if (answer != null && answer != "" && answer.Substring(0, 1) == "n")
                {
                    instanceCount = 0;
                    return;
                }
            }
        }
       
    }
}
