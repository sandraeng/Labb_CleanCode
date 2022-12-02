
using Labb_CleanCode;

namespace MooGame
{
    class MainClass
    {

        public static void Main(string[] args)
        {

            bool playOn = true;

            while (playOn)
            {
                Console.Clear();
                Console.WriteLine("\tWelcome, what game do you want to play?");
                Console.WriteLine("\n\t[1] Bulls and Cows" + "\n\t[2] Hangman" + "\n\t[3] Exit" + "\n");
                if(Int32.TryParse(Console.ReadLine(), out int playerChoice))
                {
                    if(playerChoice == 1)
                    {
                        BullsAndCowsGame game = new BullsAndCowsGame();
                        game.PlayBullsAndCows();
                    }
                    else if(playerChoice == 2)
                    {
                        HangmanGame game = new HangmanGame();
                        game.PlayHangman();
                    }
                    else if(playerChoice == 3)
                    {
                        playOn=false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
        }        


        
    }

    
}
