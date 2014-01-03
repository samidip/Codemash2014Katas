using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Bowling_Game_Kata;

namespace Bowling_Game_Test
{
    [TestClass]
    public class BowlingGameTest
    {
        [TestMethod]
        public void TestGame1()
        {
            Game bowlingGame = new Game();

            bowlingGame.Roll(1);
            bowlingGame.Roll(4);
            bowlingGame.Roll(4);
            bowlingGame.Roll(5);
            bowlingGame.Roll(6);
            bowlingGame.Roll(4); 
            bowlingGame.Roll(5);
            bowlingGame.Roll(5);
            bowlingGame.Roll(10);
            bowlingGame.Roll(0);
            bowlingGame.Roll(1);
            bowlingGame.Roll(7);
            bowlingGame.Roll(3);
            bowlingGame.Roll(6);
            bowlingGame.Roll(4);
            bowlingGame.Roll(10); 
            bowlingGame.Roll(2);
            bowlingGame.Roll(8);
            bowlingGame.Roll(6);

            int actualScore = bowlingGame.Score();
            int expectedScore = 133;

            Assert.AreEqual(expectedScore.ToString(), actualScore.ToString(), true, "Game 1 socring failed.");
        }
    }
}
