using System;

namespace LB426_LB_Janick
{
    public class CrapsGame
    {
        public void StartGame()
        {
            int dice1 = RollDice();
            int dice2 = RollDice();
            int sum = dice1 + dice2;

            Console.WriteLine($"Sie haben {dice1} und {dice2} gewürfelt, Summe: {sum}");

            if (IsWinningRoll(sum))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Gewonnen!");
                Console.ResetColor();
            }
            else if (IsLosingRoll(sum))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Verloren!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Weiter würfeln...");
            }
        }

        public int RollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        public bool IsWinningRoll(int sum)
        {
            return sum == 7 || sum == 11;
        }

        public bool IsLosingRoll(int sum)
        {
            return sum == 2 || sum == 3 || sum == 12;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CrapsGame game = new CrapsGame();
            game.StartGame();
        }
    }
}
