using System;
using System.Collections.Generic;
using System.Text;

namespace Brasta
{
    class PrintBord
    {
         //member variable
        public string [,] grid = new string[,]
           {
                { "1", "2", "3" },
                { "4", "5", "6" },
                { "7", "8", "9" }
           };

      

        //constructor
        public PrintBord (string[,] grid)
        {
            this.grid = grid;

        }

        public void Reset()
        {
            this.grid[0, 0] = "1";
            this.grid[0, 1] = "2";
            this.grid[0, 2] = "3";
            this.grid[1, 0] = "4";
            this.grid[1, 1] = "5";
            this.grid[1, 2] = "6";
            this.grid[2, 0] = "7";
            this.grid[2, 1] = "8";
            this.grid[2, 2] = "9";
        }
        
        public void WijzigingGridPlayer1(string invoer)
        {
            if (invoer == this.grid[0, 0])
            {
                this.grid[0, 0] = "X";
            } else if (invoer == this.grid[0, 1])
            {
                this.grid[0, 1] = "X";
            }
            else if (invoer == this.grid[0, 2])
            {
                this.grid[0, 2] = "X";
            }
            else if (invoer == this.grid[1, 0])
            {
                this.grid[1, 0] = "X";
            }
            else if (invoer == this.grid[1, 1])
            {
                this.grid[1, 1] = "X";
            }
            else if (invoer == this.grid[1, 2])
            {
                this.grid[1, 2] = "X";
            }
            else if (invoer == this.grid[2, 0])
            {
                this.grid[2, 0] = "X";
            }
            else if (invoer == this.grid[2, 1])
            {
                this.grid[2, 1] = "X";
            }
            else if (invoer == this.grid[2, 2])
            {
                this.grid[2, 2] = "X";
            }

        }

        public void WijzigingGridPlayer2(string invoer)
        {
            if (invoer == this.grid[0, 0])
            {
                this.grid[0, 0] = "O";
            }
            else if (invoer == this.grid[0, 1])
            {
                this.grid[0, 1] = "O";
            }
            else if (invoer == this.grid[0, 2])
            {
                this.grid[0, 2] = "O";
            }
            else if (invoer == this.grid[1, 0])
            {
                this.grid[1, 0] = "O";
            }
            else if (invoer == this.grid[1, 1])
            {
                this.grid[1, 1] = "O";
            }
            else if (invoer == this.grid[1, 2])
            {
                this.grid[1, 2] = "O";
            }
            else if (invoer == this.grid[2, 0])
            {
                this.grid[2, 0] = "O";
            }
            else if (invoer == this.grid[2, 1])
            {
                this.grid[2, 1] = "O";
            }
            else if (invoer == this.grid[2, 2])
            {
                this.grid[2, 2] = "O";
            }

        }

        public void BordPrintenOpConsole()
        {
            
            Console.Clear();
            Console.WriteLine("                           ");
            Console.WriteLine(" {0} | {1} | {2}", grid[0, 0], grid[0, 1], grid[0, 2]);
            Console.WriteLine("----------");
            Console.WriteLine(" {0} | {1} | {2}", grid[1, 0], grid[1, 1], grid[1, 2]);
            Console.WriteLine("----------");
            Console.WriteLine(" {0} | {1} | {2}", grid[2, 0], grid[2, 1], grid[2, 2]);
            Console.WriteLine("                           ");

        }
    }

}
