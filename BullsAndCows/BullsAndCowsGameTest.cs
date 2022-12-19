using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Labb_CleanCode.BullsAndCows
{
    [TestClass]
    public class BullsAndCowsGameTest
    {

        [TestMethod()]
        public void TotalInstancesOfTheClass()
        {
            BullsAndCowsGame game = new BullsAndCowsGame();
            Assert.AreEqual(1, game.instanceCount);
        }

    }
}
