using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_CleanCode.Player
{
    class PlayerData
    {
        public string PlayerName { get; private set; }
        public int NumberOfGames { get; private set; }
        public string TypeOfGame { get; private set; }
        int TotalGuesses;


        public PlayerData(string name, int guesses, string typeOfGame)
        {
            PlayerName = name;
            NumberOfGames = 1;
            TotalGuesses = guesses;
            TypeOfGame = typeOfGame;
        }

        public void Update(int guesses)
        {
            TotalGuesses += guesses;
            NumberOfGames++;
        }

        public double Average()
        {
            return (double)TotalGuesses / NumberOfGames;
        }


        public override bool Equals(object p)
        {
            return PlayerName.Equals(((PlayerData)p).PlayerName);
        }


        public override int GetHashCode()
        {
            return PlayerName.GetHashCode();
        }
    }
}
