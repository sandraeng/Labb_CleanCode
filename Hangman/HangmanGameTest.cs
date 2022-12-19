
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Labb_CleanCode.Hangman
{
    [TestClass()]
    public class HangmanGameTest
    {
        [TestMethod()]
        public void TotalInstancesOfTheClass()
        {
            HangmanGame game = new HangmanGame();
            Assert.AreEqual(1, game.instanceCount);
        }
    }
}
