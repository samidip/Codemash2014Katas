using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Game_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bowling ring. Please enter the pins you knocked over in each roll, as comma separated values. Max of 21: ");
            string pinRollsString = Console.ReadLine();
            string[] pinRolls = pinRollsString.Split(new string[]{","}, StringSplitOptions.None);

            Game bowlingGame = new Game();
            foreach (string individualScore in pinRolls)
            {
                bowlingGame.Roll(Convert.ToInt16(individualScore));
            }
            int gameScore = bowlingGame.Score();

            Console.WriteLine("Game Score: " + gameScore);
        }
    }

    public class Game 
    {
      private int[] rolls = new int[21];
      private int currentRoll = 0;

      public void Roll(int pins)
      {
          rolls[currentRoll++] = pins;
      }

      public int Score()
      {
          int score = 0;
          int frameIndex = 0;
          for (int frame = 0; frame < 10; frame++)
          {
              if (isStrike(frameIndex))
              {
                  score += 10 + strikeBonus(frameIndex);
                  frameIndex++;
              }
              else if (isSpare(frameIndex))
              {
                  score += 10 + spareBonus(frameIndex);
                  frameIndex += 2;
              }
              else
              {
                  score += sumOfBallsInFrame(frameIndex);
                  frameIndex += 2;
              }
          }
          return score;
      }

      private bool isStrike(int frameIndex)
      {
          return rolls[frameIndex] == 10;
      }

      private int sumOfBallsInFrame(int frameIndex)
      {
          return rolls[frameIndex] + rolls[frameIndex + 1];
      }

      private int spareBonus(int frameIndex)
      {
          return rolls[frameIndex + 2];
      }

      private int strikeBonus(int frameIndex)
      {
          return rolls[frameIndex + 1] + rolls[frameIndex + 2];
      }

      private bool isSpare(int frameIndex)
      {
          return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
      }
    }
}
