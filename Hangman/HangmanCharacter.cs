using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_CleanCode.Hangman
{
    public static class HangmanCharacter
    {
        public static void TheHangman(int wrongGuesses)
        {

            if (wrongGuesses == 0)
            {
                Console.WriteLine("\n\t _____");
                Console.WriteLine("\t|/\n" + "\t|\n" + "\t|\n" + "\t|\n" + "\t|\n" + "\t|" + "____________\n" + "\t |_|      |_|");
            }
            else if (wrongGuesses == 1)
            {
                Console.WriteLine("\n\t _____");
                Console.WriteLine("\t|" + "     |\n" + "\t|\n" + "\t|\n" + "\t|\n" + "\t|\n" + "\t|" + "____________\n" + "\t |_|      |_|");
            }
            else if (wrongGuesses == 2)
            {
                Console.WriteLine("\n\t _____");
                Console.WriteLine("\t|" + "     |\n" + "\t|" + "     O\n" + "\t|\n" + "\t|\n" + "\t|\n" + "\t|" + "____________\n" + "\t |_|      |_|");
            }
            else if (wrongGuesses == 3)
            {
                Console.WriteLine("\n\t _____");
                Console.WriteLine("\t|" + "     |\n" + "\t|" + "     O\n" + "\t|" + "    /\n" + "\t|\n" + "\t|\n" + "\t|" + "____________\n" + "\t |_|      |_|");
            }
            else if (wrongGuesses == 4)
            {
                Console.WriteLine("\n\t _____");
                Console.WriteLine("\t|" + "     |\n" + "\t|" + "     O\n" + "\t|" + "    /|\n" + "\t|\n" + "\t|\n" + "\t|" + "____________\n" + "\t |_|      |_|");
            }
            else if (wrongGuesses == 5)
            {
                Console.WriteLine("\n\t _____");
                Console.WriteLine("\t|" + "     |\n" + "\t|" + "     O\n" + "\t|" + "    /|\\\n" + "\t|\n" + "\t|\n" + "\t|" + "____________\n" + "\t |_|      |_|");
            }
            else if (wrongGuesses == 6)
            {
                Console.WriteLine("\n\t _____");
                Console.WriteLine("\t|" + "     |\n" + "\t|" + "     O\n" + "\t|" + "    /|\\\n" + "\t|" + "    /\n" + "\t|\n" + "\t|" + "____________\n" + "\t |_|      |_|");
            }
            else if (wrongGuesses == 7)
            {
                Console.WriteLine("\n\t _____");
                Console.WriteLine("\t|" + "     |\n" + "\t|" + "     O\n" + "\t|" + "    /|\\\n" + "\t|" + "    / \\\n" + "\t|\n" + "\t|" + "____________\n" + "\t |_|      |_|");
            }

        }
    }
}
