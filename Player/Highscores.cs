using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labb_CleanCode.Player
{
    public static class Highscores
    {
        public static void AddHighscore(string gameName, string playerName, int numberOfGuesses)
        {
            StreamWriter writeToFile = new StreamWriter("result.txt", append: true);
            writeToFile.WriteLine(playerName + "#&#" + numberOfGuesses + "#&#" + gameName);
            writeToFile.Close();
        }

        public static void ShowHighscores(string typeOfGame)
        {
            StreamReader getFromFile = new StreamReader("result.txt");
            List<PlayerData> results = new List<PlayerData>();
            string scoreLine;
            while ((scoreLine = getFromFile.ReadLine()) != null)
            {
                string[] nameScoreAndGameType = scoreLine.Split(new string[] { "#&#" }, StringSplitOptions.None);
                string name = nameScoreAndGameType[0];
                int guesses = Convert.ToInt32(nameScoreAndGameType[1]);
                string game = nameScoreAndGameType[2];
                PlayerData playerData = new PlayerData(name, guesses, game);
                int pos = results.IndexOf(playerData);
                if (pos < 0 && typeOfGame == playerData.TypeOfGame)
                {
                    results.Add(playerData);
                }
                else if (typeOfGame == playerData.TypeOfGame)
                {
                    results[pos].Update(guesses);
                }


            }
            results.Sort((playerData1, playerData2) => playerData1.Average().CompareTo(playerData2.Average()));
            Console.WriteLine("\tPlayer     games   average     type of game");
            foreach (PlayerData p in results)
            {
                if (p.TypeOfGame == typeOfGame)
                {
                    Console.WriteLine(string.Format("\t{0,-9}{1,5:D}{2,9:F2}{3,20}", p.Name, p.NumberOfGames, p.Average(), p.TypeOfGame));
                }
            }
            getFromFile.Close();
        }
    }
}
