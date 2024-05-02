using LB426_LB_Janick;

namespace LB246_FinalGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen im Casino!");
            Console.WriteLine("Welches Spiel möchtest du spielen?");
            Console.WriteLine("1. Slotmaschine");
            Console.WriteLine("2. Craps");

            int choice;
            while (true)
            {
                Console.Write("Bitte wähle eine Option (1 oder 2): ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if (choice == 1)
                    {
                        PlaySlotMachine();
                        break;
                    }
                    else if (choice == 2)
                    {
                        PlayCraps();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte wähle 1 oder 2.");
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte wähle 1 oder 2.");
                }
            }
            static void PlaySlotMachine()
            {
                var machine = new LB426_FinalGame.SlotMachine();


                machine.AddSymbol(new LB426_FinalGame.Symbol("Cherry", 10, ConsoleColor.Red));
                machine.AddSymbol(new LB426_FinalGame.Symbol("Orange", 20, ConsoleColor.Yellow));
                machine.AddSymbol(new LB426_FinalGame.Symbol("Lemon", 30, ConsoleColor.Green));

                machine.StartGame();
            }

            static void PlayCraps()
            {
            
                    CrapsGame game = new CrapsGame(100); // Startguthaben des Spielers
                    game.StartGame();
                
            }
        }
    }
}
