using Labb_CleanCode.BullsAndCows;
using Labb_CleanCode.Hangman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_CleanCode.Factory
{
    public static class GameFactory
    {
        public static IGame StartNewGame(string gameName)
        {
            if (gameName == "Hangman")
                return new HangmanGame();
            else
                return new BullsAndCowsGame();
        }
    }
}
