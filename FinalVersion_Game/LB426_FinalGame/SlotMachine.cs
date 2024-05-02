using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB426_FinalGame
{
    using System;
    using System.Collections.Generic;


    public class SlotMachine
    {
        private List<Symbol> symbols = new List<Symbol>();
        private int playerChips = 1000; // Startguthaben

        public void AddSymbol(Symbol symbol)
        {
            symbols.Add(symbol);
        }

        public void StartGame()
        {
            Console.WriteLine("Willkommen zur Slotmachine!");
            Console.WriteLine("");
            Console.ForegroundColor= ConsoleColor.Blue;    
            Console.WriteLine("Ziel: Erziele Gewinnkombinationen auf den Walzen.\r\nEinsatz: Setze deinen Einsatz vor dem Drehen.\r\nDrehen: Starte das Spiel und warte auf die Ergebnisse.\r\nGewinne: Erhalte Auszahlungen für passende Symbole.\r\nVerantwortung: Spiele verantwortungsbewusst und innerhalb deiner Grenzen.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            while (playerChips > 0)
            {
                Console.WriteLine("Dein aktuelles Guthaben: " + playerChips + " Chips");


                Console.WriteLine("Bitte gib deinen Einsatz (zwischen 1 und " + playerChips + " Chips) ein:");
                int betAmount = GetBetAmount();


                Console.WriteLine("Drücke Enter, um zu spinnen...");
                Console.ReadLine();
                Spin(betAmount);
                if (playerChips <= 0)
                {
                    Console.WriteLine("Du hast keine Chips mehr. Das Spiel endet.");
                    break;
                }
                Console.WriteLine("Möchtest du noch einmal spielen? (ja/nein)");
                if (Console.ReadLine().ToLower() != "ja")
                {
                    break;
                }
            }

            Console.WriteLine("Vielen Dank fürs Spielen! Dein Endguthaben beträgt: " + playerChips + " Chips");
        }

        public int GetBetAmount()
        {
            int betAmount;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out betAmount))
                {
                    if (betAmount >= 1 && betAmount <= playerChips)
                    {
                        return betAmount;
                    }
                }
                Console.WriteLine("Ungültiger Einsatz. Bitte gib einen Einsatz zwischen 1 und " + playerChips + " Chips ein:");
            }
        }

        private void Spin(int betAmount)
        {
            Random random = new Random();
            Symbol[] result = new Symbol[3];

            for (int i = 0; i < 3; i++)
            {
                int randomIndex = random.Next(symbols.Count);
                result[i] = symbols[randomIndex];
            }

            DisplayResult(result, betAmount);
        }

        private void DisplayResult(Symbol[] result, int betAmount)
        {
            Console.WriteLine("Ergebnis:");

            foreach (var symbol in result)
            {
                Console.ForegroundColor = symbol.Color;
                Console.Write(symbol.Name + " ");
                Console.ResetColor();
            }
            Console.WriteLine();


            int totalWin = CalculateWin(result, betAmount);
            Console.WriteLine("Gewinn: " + totalWin + " Chips");

            // Update von Guthaben
            playerChips += totalWin - betAmount;
            Console.WriteLine("Aktuelles Guthaben: " + playerChips + " Chips");

            // mögliche Wins
            Console.WriteLine("Mögliche Gewinne:");
            foreach (var symbol in symbols)
            {
                Console.ForegroundColor = symbol.Color;
                Console.WriteLine(symbol.Name + ": " + symbol.Value + " Chips");
                Console.ResetColor();
            }
        }

        private int CalculateWin(Symbol[] result, int betAmount)
        {
            int totalWin = 0;

            // Wenn alle Symbole gleich ,entsprechender Gewinn ausgezahlt
            if (result[0].Name == result[1].Name && result[1].Name == result[2].Name)
            {
                totalWin = result[0].Value * betAmount;
            }

            return totalWin;
        }
    }



}
