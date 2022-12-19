using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_CleanCode.Player
{
    public class InputController
    {
        public string CheckPlayerNameInput()
        {
            bool correctInput = false;
            string playerName = "";
            while (!correctInput)
            {
                Console.Write("\n\tEnter your user name: ");
                playerName = Console.ReadLine() ?? string.Empty;
                if (!CheckForEmptyOrNullInput(playerName) || playerName.Length !< 2)
                {
                    Console.WriteLine("\n\tInput name with atleast 2 characters");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\tChosen name = {0}", playerName);
                    correctInput = true;
                }
            }
            return playerName;
        }

        public string CheckGuessInput()
        {
            bool correctInput = false;
            string userGuess = "";
            while (!correctInput)
            {
                userGuess = Console.ReadLine() ?? string.Empty;
                if (!CheckForEmptyOrNullInput(userGuess))
                {
                    Console.WriteLine("Please enter a valid guess");
                }
                else
                {
                    correctInput = true;
                }
            }
            return userGuess;
        }

        private bool CheckForEmptyOrNullInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
