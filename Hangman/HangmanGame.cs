
using Labb_CleanCode.Interface;
using Labb_CleanCode.Player;

namespace Labb_CleanCode.Hangman
{
    public class HangmanGame: IGame
    {
        public int instanceCount { get; set; } = 0;

        public HangmanGame()
        {
            if (instanceCount > 0)
            {
                throw new Exception("More than 1 instance created");
            }
            instanceCount++;
        }
        public void PlayGame()
        {
            Console.Clear();
            InputController inputController = new InputController();
            HangmanController controller = new HangmanController();
            Console.WriteLine("\tWelcome to hangman, you have 7 guesses to get the word right!\n");
            string playerName = inputController.CheckPlayerNameInput();          
            controller.GetRandomWord();

            while (true)
            {
                HangmanCharacter.TheHangman(controller.WrongGuesses);
                Console.Write("\n\t");
                foreach (var character in controller.HiddenWord)
                {
                    Console.Write(character + " ");
                }
                Console.Write("\n\n\tGuessed letters: ");
                foreach (var letter in controller.GuessedLetters)
                {
                    Console.Write(letter);
                }
                Console.Write("\n\tYour guess: ");
                string userGuess = inputController.CheckGuessInput();
                controller.CheckUserGuess(userGuess);
                bool lettersStillHidden = controller.CheckWin();
                if (!lettersStillHidden)
                {
                    Console.WriteLine("\tCongratulations you guessed the word!");
                    Highscores.AddHighscore(controller.GameName, playerName, controller.WrongGuesses);
                    Highscores.ShowHighscores(controller.GameName);
                    Console.WriteLine("\tPress any key to go back to the main meny");
                    controller.GuessedLetters.Clear();
                    controller.WrongGuesses = 0;
                    Console.ReadLine();
                    instanceCount = 0;
                    return;
                }
                if (controller.WrongGuesses >= 7)
                {
                    HangmanCharacter.TheHangman(controller.WrongGuesses);
                    controller.GameOverText();
                    Console.WriteLine("\tYou are out of guesses, the word was {0}", controller.WordToGuess);
                    Highscores.AddHighscore(controller.GameName, playerName, controller.WrongGuesses);
                    Highscores.ShowHighscores(controller.GameName);
                    Console.WriteLine("\tPress any key to go back to the main meny");
                    controller.GuessedLetters.Clear();
                    controller.WrongGuesses = 0;
                    Console.ReadLine();
                    instanceCount = 0;
                    return;
                }
            }
        }
    }
}
