using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_CleanCode.Hangman
{
    [TestClass]
    public class HangmanControllerTest
    {
        [TestMethod()]
        public void CheckIfWordsHaveSameLenght()
        {
            HangmanController controller = new HangmanController();
            Assert.AreEqual(controller.HiddenWord.Count(), controller.WordToGuess.Count());
        }
    }
}
