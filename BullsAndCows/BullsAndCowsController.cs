using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_CleanCode.BullsAndCows
{
    public class BullsAndCowsController
    {
        public string GameName = "Bulls and Cows";

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
