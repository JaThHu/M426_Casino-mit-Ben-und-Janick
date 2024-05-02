using System;

namespace LB426_LB_Janick
{
    public class CrapsGame
    {
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            CrapsGame game = new CrapsGame();
            game.DisplayInstructions();
        }
    }
}
