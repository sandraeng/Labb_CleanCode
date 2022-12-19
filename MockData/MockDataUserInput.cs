using Labb_CleanCode.BullsAndCows;
using Labb_CleanCode.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_CleanCode.MockData
{
    public class MockDataUserInput : IUserInput
    {
        public string GetPlayerName()
        {
            return "DB";
        }
        public string GetPlayerNameAsEmptyString()
        {
            return "";
        }
        public string PlayerGuessCorrectBullsAndCows()
        {
            BullsAndCowsController game = new BullsAndCowsController();
            string numberToGuess = game.GenerateNumberToGuess();
            string playerGuess = numberToGuess;
            if (playerGuess == numberToGuess)
                return "BBBB";
            else
                return "";
        }
    }
}
