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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Willkommen beim Craps-Spiel!\n");
            Console.ResetColor();
            DisplayInstructions();

            while (_balance > 0)
            {
                int betAmount = GetBetAmount();

                Console.WriteLine("Drücken Sie eine beliebige Taste, um zu würfeln...");
                Console.ReadKey();

                int dice1 = RollDice();
                int dice2 = RollDice();
                int sum = dice1 + dice2;

                Console.WriteLine($"Sie haben {dice1} und {dice2} gewürfelt, Summe: {sum}");

                if (IsWinningRoll(sum))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Gewonnen!");
                    Console.ResetColor();
                    _balance += betAmount; // Gewinn
                }
                else if (IsLosingRoll(sum))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Verloren!");
                    Console.ResetColor();
                    _balance -= betAmount; // Verlust
                }
                else
                {
                    Console.WriteLine("Weiter würfeln...");
                    int point = sum;

                    while (true)
                    {
                        Console.WriteLine("Drücken Sie eine beliebige Taste, um zu würfeln...");
                        Console.ReadKey();

                        int newDice1 = RollDice();
                        int newDice2 = RollDice();
                        int newSum = newDice1 + newDice2;

                        Console.WriteLine($"Sie haben {newDice1} und {newDice2} gewürfelt, Summe: {newSum}");

                        if (newSum == point)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Gewonnen!");
                            Console.ResetColor();
                            _balance += betAmount; // Gewinn
                            break;
                        }
                        else if (newSum == 7)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Verloren!");
                            Console.ResetColor();
                            _balance -= betAmount; // Verlust
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Weiter würfeln...");
                        }
                    }
                }
            }

            Console.WriteLine("Sie haben kein Guthaben mehr. Das Spiel ist vorbei!");
        }

        public void DisplayInstructions()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Anleitung für das Craps-Spiel\n");

            Console.WriteLine("Ziel:");
            Console.WriteLine("Gewinne durch das Werfen von Würfeln.\n");

            Console.WriteLine("Spielablauf:");
            Console.WriteLine("- Platziere einen Einsatz.");
            Console.WriteLine("- Würfle mit zwei Würfeln.");
            Console.WriteLine("- Bei 7 oder 11 gewinnst du sofort.");
            Console.WriteLine("- Bei 2, 3 oder 12 verlierst du sofort.");
            Console.WriteLine("- Bei jeder anderen Zahl wird diese als 'Point' festgelegt.");
            Console.WriteLine("- Würfle erneut, bis du entweder den 'Point' triffst und gewinnst oder eine 7 triffst und verlierst.\n");

            Console.WriteLine("Spielregeln:");
            Console.WriteLine("- Gewinne: 7 oder 11 beim ersten Wurf, oder treffe den 'Point'.");
            Console.WriteLine("- Verliere: 2, 3 oder 12 beim ersten Wurf, oder würfle eine 7 nach Festlegung des 'Point'.\n");

            Console.WriteLine("Spielende:");
            Console.WriteLine("- Das Spiel endet, wenn dein Guthaben aufgebraucht ist oder du das Spiel beendest.");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------\n");
        }

        public int GetBetAmount()
        {
            int betAmount;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Aktuelles Guthaben: {_balance}");
                Console.ResetColor();
                Console.Write("Bitte geben Sie Ihren Einsatz ein: ");
            } while (!int.TryParse(Console.ReadLine(), out betAmount) || betAmount <= 0 || betAmount > _balance);

            return betAmount;
        }

        public int RollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        public bool IsWinningRoll(int sum)
        {
            if (sum == 7 || sum == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsLosingRoll(int sum)
        {
            if (sum == 2 || sum == 3 || sum == 12)
            {
                return true;
            }
            else
            {
                return false;
            }
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
