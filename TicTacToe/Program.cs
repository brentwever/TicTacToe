using System;

namespace Brasta
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[,] grid = new string[,]
            {
                { "1", "2", "3" },
                { "4", "5", "6" },
                { "7", "8", "9" }
            };

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Player 1 : Wat is uw naam? : ");
            string naam1 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Player 2 : Wat is uw naam? : ");
            string naam2 = Console.ReadLine();

            int counter = 0;
            bool nietdrieoprij = true;

            Console.ForegroundColor = ConsoleColor.White;
            PrintBord bordprinten = new PrintBord(grid);
            bordprinten.BordPrintenOpConsole();

            while (nietdrieoprij)

            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Aantal beurten: " + counter);

                // voor player 1
                Console.WriteLine(naam1 + " : kies uw veld: ");
                string invoerp1 = Console.ReadLine();
                counter++;
                Console.ForegroundColor = ConsoleColor.White;
                bordprinten.WijzigingGridPlayer1(invoerp1);
                bordprinten.BordPrintenOpConsole();

                if ((grid[0, 0] == grid[0, 1]) && (grid[0, 1] == grid[0, 2]) && (grid[0, 0] == grid[0, 2]) ||
                 (grid[1, 0] == grid[1, 1]) && (grid[1, 1] == grid[1, 2]) && (grid[1, 0] == grid[1, 2]) ||
                  (grid[2, 0] == grid[2, 1]) && (grid[2, 1] == grid[2, 2]) && (grid[2, 0] == grid[2, 2]) ||
                  (grid[0, 0] == grid[1, 0]) && (grid[1, 0] == grid[2, 0]) && (grid[2, 0] == grid[0, 0]) ||
                  (grid[0, 1] == grid[1, 1]) && (grid[1, 1] == grid[2, 1]) && (grid[2, 1] == grid[0, 1]) ||
                  (grid[0, 2] == grid[1, 2]) && (grid[1, 2] == grid[2, 2]) && (grid[2, 2] == grid[0, 2]) ||
                  (grid[0, 0] == grid[1, 1]) && (grid[1, 1] == grid[2, 2]) && (grid[2, 2] == grid[0, 0]) ||
                  (grid[2, 0] == grid[1, 1]) && (grid[1, 1] == grid[0, 2]) && (grid[0, 2] == grid[2, 0]))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(naam1 + " wint!");
                    nietdrieoprij = false;

                }
                else if (counter == 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Helaas niemand heeft gewonnen");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Aantal beurten: " + counter);

                    // voor player 2
                    Console.WriteLine(naam2 + " : kies uw veld: ");
                    string invoerp2 = Console.ReadLine();
                    counter++;

                    bordprinten.WijzigingGridPlayer2(invoerp2);
                    Console.ForegroundColor = ConsoleColor.White;
                    bordprinten.BordPrintenOpConsole();
                    if ((grid[0, 0] == grid[0, 1]) && (grid[0, 1] == grid[0, 2]) && (grid[0, 0] == grid[0, 2]) ||
                         (grid[1, 0] == grid[1, 1]) && (grid[1, 1] == grid[1, 2]) && (grid[1, 0] == grid[1, 2]) ||
                         (grid[2, 0] == grid[2, 1]) && (grid[2, 1] == grid[2, 2]) && (grid[2, 0] == grid[2, 2]) ||
                         (grid[0, 0] == grid[1, 0]) && (grid[1, 0] == grid[2, 0]) && (grid[2, 0] == grid[0, 0]) ||
                          (grid[0, 1] == grid[1, 1]) && (grid[1, 1] == grid[2, 1]) && (grid[2, 1] == grid[0, 1]) ||
                         (grid[0, 2] == grid[1, 2]) && (grid[1, 2] == grid[2, 2]) && (grid[2, 2] == grid[0, 2]) ||
                          (grid[0, 0] == grid[1, 1]) && (grid[1, 1] == grid[2, 2]) && (grid[2, 2] == grid[0, 0]) ||
                         (grid[2, 0] == grid[1, 1]) && (grid[1, 1] == grid[0, 2]) && (grid[0, 2] == grid[2, 0]))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(naam2 + " wint!");
                        nietdrieoprij = false;
                    }
                    else if (counter == 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Helaas niemand heeft gewonnen");
                    }                    
                    else
                    {
                        continue;
                    }
                    // einde van while loop
                }

                Console.WriteLine("GAME OVER!!");
                Console.WriteLine("Wilt u nog een potje spelen? Y/N : ");
                string antwoord = Console.ReadLine();
                if (antwoord == "Y" || antwoord == "y" || antwoord == "j")
                {
                    counter = 0;
                    nietdrieoprij = true;
                    Console.Clear();
                    bordprinten = new PrintBord(grid);
                    bordprinten.Reset();
                    Console.ForegroundColor = ConsoleColor.White;
                    bordprinten.BordPrintenOpConsole();                    
                    continue;
                                                       }
                else
                {
                    break;
                }
            }
        }
    }
}




       
    
          

