using System;

namespace LB426_LB_Janick
{
    public class CrapsGame
    {
        private List<string> gameHistory = new List<string>();

        public void StartGame()
        {
            int dice1 = RollDice();
            int dice2 = RollDice();
            int sum = dice1 + dice2;

            string result = $"Sie haben {dice1} und {dice2} gewürfelt, Summe: {sum}";

            if (IsWinningRoll(sum))
            {
                result += " - Gewonnen!";
            }
            else if (IsLosingRoll(sum))
            {
                result += " - Verloren!";
            }
            else
            {
                result += " - Weiter würfeln...";
            }

            Console.WriteLine(result);
            gameHistory.Add(result);
        }

        public void DisplayGameHistory()
        {
            Console.WriteLine("Spielhistorie:");
            foreach (var entry in gameHistory)
            {
                Console.WriteLine(entry);
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
            game.DisplayGameHistory();
        }
    }
}
