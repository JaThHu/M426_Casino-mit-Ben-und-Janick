using System;

namespace LB426_LB_Janick
{
    public class Player
    {
        private int _balance;

        public Player(int initialBalance)
        {
            _balance = initialBalance;
        }

        public int Balance => _balance;

        public void AddMoney(int amount)
        {
            _balance += amount;
        }

        public void DeductMoney(int amount)
        {
            _balance -= amount;
        }
    }

    public class CrapsGame
    {
        private Player _player;

        public CrapsGame(int initialBalance)
        {
            _player = new Player(initialBalance);
        }

        public void StartGame()
        {
            // Spiellogik bleibt unverändert
        }

        public int GetPlayerBalance()
        {
            return _player.Balance;
        }

        // Weitere Methoden für die Spiellogik...
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
