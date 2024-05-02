using System;

namespace LB426_LB_Janick
{
    public class CrapsGame
    {
        private int _balance;

        public CrapsGame(int initialBalance)
        {
            _balance = initialBalance;
        }

        public void StartGame()
        {
            PlaceBet(); // Einsatz platzieren
            // Starte das Craps-Spiel
            Console.WriteLine("Das Spiel beginnt...");
        }

        public void PlaceBet()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Aktuelles Guthaben: {_balance}");
            Console.ResetColor();
            Console.Write("Bitte geben Sie Ihren Einsatz ein: ");
            int betAmount;
            while (!int.TryParse(Console.ReadLine(), out betAmount) || betAmount <= 0 || betAmount > _balance)
            {
                Console.WriteLine("Ungültiger Einsatz. Bitte geben Sie einen gültigen Einsatz ein.");
                Console.Write("Bitte geben Sie Ihren Einsatz ein: ");
            }
            Console.WriteLine($"Einsatz von {betAmount} platziert.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CrapsGame game = new CrapsGame(100); // Startguthaben des Spielers
            game.StartGame();
        }
    }
}
