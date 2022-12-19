
using Labb_CleanCode.Factory;
using Labb_CleanCode.Interface;

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
                        IGame game = GameFactory.StartNewGame("Bulls and Cows");
                        game.PlayGame();                        
                    }
                    else if(playerChoice == 2)
                    {
                        IGame game = GameFactory.StartNewGame("Hangman");
                        game.PlayGame();
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
