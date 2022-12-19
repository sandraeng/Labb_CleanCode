using Labb_CleanCode.MockData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_CleanCode.Player
{
    [TestClass]
    public class InputControllerTest
    {
        [TestMethod()]
        public void CheckForCorrectPlayerNameInput()
        {
            MockDataUserInput mockData = new MockDataUserInput();
            string playerName = mockData.GetPlayerName();
            Assert.IsTrue(playerName.Count() <= 2);
        }

        [TestMethod()]
        public void CheckIfInputIsNullOrEmpty()
        {
            MockDataUserInput mockData = new MockDataUserInput();
            string playerName = mockData.GetPlayerNameAsEmptyString();
            Assert.IsTrue(playerName == "" || playerName == null);
        }

    }
}
