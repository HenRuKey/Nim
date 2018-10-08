using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NimLibrary;

namespace NimTests
{
    [TestClass]
    public class ControllerTest
    {

        [TestMethod]
        public void NameOfPlayerOneInitialized()
        {
            string name = "Name1";
            GameController gc = new GameController("PvP", "easy", name, "Name2");
            Assert.AreEqual(name, gc.player1.Name);
        }

        [TestMethod]
        public void NameOfPlayerTwoInitialized()
        {
            string name = "Name2";
            GameController gc = new GameController("PvP", "easy", "Name1", name);
            Assert.AreEqual(name, gc.player2.Name);
        }

        [TestMethod]
        public void PlayerTwoPvPIsNotBot()
        {
            GameController gc = new GameController("PvP", "easy", "name1", "name2");
            Assert.IsFalse(gc.player2.IsComputer);
        }

        [TestMethod]
        public void PlayerTwoPvCIsBot()
        {
            GameController gc = new GameController("PvC", "easy", "name1", "name2");
            Assert.IsTrue(gc.player2.IsComputer);
        }

        [TestMethod]
        public void PiecesAreRemovedFromPile()
        {
            try
            {
                GameController gc = new GameController("PvC", "easy", "name1", "name2");
                gc.Piles[0][0].IsSelected = true;
                gc.TakeTurn();
                int expectedPileSize = 2;
                int actualPileSize = gc.Piles[0].Size;
                Assert.AreEqual(expectedPileSize, actualPileSize);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Trace.WriteLine("Pile wasn't populated.");
                Assert.Fail();
            }
        }
    }
}
