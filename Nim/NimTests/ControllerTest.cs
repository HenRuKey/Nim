using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nim.Models;
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
            GameController gc = new GameController("PvP", "Easy", name, "Name2");
            Assert.AreEqual(name, gc.player1.Name);
        }

        [TestMethod]
        public void NameOfPlayerTwoInitialized()
        {
            string name = "Name2";
            GameController gc = new GameController("PvP", "Easy", "Name1", name);
            Assert.AreEqual(name, gc.player2.Name);
        }

        [TestMethod]
        public void PlayerTwoPvPIsNotBot()
        {
            GameController gc = new GameController("PvP", "Easy", "name1", "name2");
            Assert.IsFalse(gc.player2.IsComputer);
        }

        [TestMethod]
        public void PlayerTwoPvCIsBot()
        {
            GameController gc = new GameController("PvC", "Easy", "name1", "name2");
            Assert.IsTrue(gc.player2.IsComputer);
        }

        [TestMethod]
        public void SelectedPiecesAreRemovedFromPile()
        {
            GameController gc = new GameController("PvP", "Easy", "name1", "name2");
            gc.Piles[0][0].IsSelected = true;
            gc.TakeTurn();
            int expectedPileSize = 2;
            int actualPileSize = gc.Piles[0].Count;
            Assert.AreEqual(expectedPileSize, actualPileSize);
        }

        [TestMethod]
        public void NoSelectedPiecesArePresentAfterTurn()
        {
            GameController gc = new GameController("PvC", "Easy", "name1", "name2");
            gc.Piles[0][0].IsSelected = true;
            gc.TakeTurn();
            int expectedCount = 0;
            int actualCount = gc.Piles[0].Where(p => p.IsSelected).Count();
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void EasyGameHasCorrectNumberOfPilesAndPieces()
        {
            int numberOfPiles = 2;
            int numberOfPieces = 3;
            string difficulty = "Easy";
            GameController gc = new GameController("PvP", difficulty, "name1", "name2");
            int actualNumberOfPiles = gc.Piles.Count;
            int numberOfPiecesPile1 = gc.Piles[0].Count;
            int numberOfPiecesPile2 = gc.Piles[1].Count;
            bool pilesAreEqualInSize = numberOfPiecesPile1 == numberOfPiecesPile2;
            Assert.IsTrue(pilesAreEqualInSize && 
                numberOfPiles == actualNumberOfPiles && 
                numberOfPiecesPile1 == numberOfPieces);
        }

        [TestMethod]
        public void MediumGameHasCorrectNumberOfPilesAndPieces()
        {
            int expectedNumOfPiles = 3;
            int expectedNumOfPiecesPile1 = 2;
            int expectedNumOfPiecesPile2 = 5;
            int expectedNumOfPiecesPile3 = 7;
            string difficulty = "Medium";
            GameController gc = new GameController("PvP", difficulty, "name1", "name2");
            int actualNumOfPiles = gc.Piles.Count;
            int actualNumOfPiecesPile1 = gc.Piles[0].Count;
            int actualNumOfPiecesPile2 = gc.Piles[1].Count;
            int actualNumOfPiecesPile3 = gc.Piles[2].Count;
            Assert.IsTrue(expectedNumOfPiles == actualNumOfPiles &&
                expectedNumOfPiecesPile1 == actualNumOfPiecesPile1 &&
                expectedNumOfPiecesPile2 == actualNumOfPiecesPile2 &&
                expectedNumOfPiecesPile3 == actualNumOfPiecesPile3);

        }

        [TestMethod]
        public void HardGameHasCorrectNumberOfPilesAndPieces()
        {
            int expectedNumOfPiles = 4;
            int expectedNumOfPiecesPile1 = 2;
            int expectedNumOfPiecesPile2 = 3;
            int expectedNumOfPiecesPile3 = 8;
            int expectedNumOfPiecesPile4 = 9;
            string difficulty = "Hard";
            GameController gc = new GameController("PvP", difficulty, "name1", "name2");
            int actualNumOfPiles = gc.Piles.Count;
            int actualNumOfPiecesPile1 = gc.Piles[0].Count;
            int actualNumOfPiecesPile2 = gc.Piles[1].Count;
            int actualNumOfPiecesPile3 = gc.Piles[2].Count;
            int actualNumOfPiecesPile4 = gc.Piles[3].Count;
            Assert.IsTrue(expectedNumOfPiles == actualNumOfPiles &&
                expectedNumOfPiecesPile1 == actualNumOfPiecesPile1 &&
                expectedNumOfPiecesPile2 == actualNumOfPiecesPile2 &&
                expectedNumOfPiecesPile3 == actualNumOfPiecesPile3 &&
                expectedNumOfPiecesPile4 ==actualNumOfPiecesPile4);
        }
    }
}
