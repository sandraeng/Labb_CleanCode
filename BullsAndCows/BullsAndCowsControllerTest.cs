﻿using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Labb_CleanCode.BullsAndCows
{
    [TestClass]
    public class BullsAndCowsControllerTest
    {
        [TestMethod()]
        public void RandomNumbersIsUnique()
        {
            Random numbers = new Random();
            string randomNumbers = "" + numbers.Next(10) + numbers.Next(10) + numbers.Next(10) + numbers.Next(10);
            BullsAndCowsController controller = new BullsAndCowsController();
            var generatedNumber = controller.GenerateNumberToGuess();
            Assert.AreEqual(randomNumbers.Count(), generatedNumber.ToArray().Distinct().Count());
        }
    }
}
