using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_CleanCode
{
    class PlayerData
    {
        public string Name { get; private set; }
        public int NumberOfGames { get; private set; }
        public string TypeOfGame { get; private set; }
        int totalGuess;


        public PlayerData(string name, int guesses, string typeOfGame)
        {
            this.Name = name;
            NumberOfGames = 1;
            totalGuess = guesses;
            TypeOfGame = typeOfGame;
        }

        public void Update(int guesses)
        {
            totalGuess += guesses;
            NumberOfGames++;
        }

        public double Average()
        {
            return (double)totalGuess / NumberOfGames;
        }


        public override bool Equals(Object p)
        {
            return Name.Equals(((PlayerData)p).Name);
        }


        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
