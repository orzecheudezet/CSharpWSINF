using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        public Board()
        {

        }
        public char[,] Board1 = new char[3, 3];



        public void PrintBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                Console.Write("| ");
                for (int column = 0; column < 3; column++)
                {
                    Console.Write(Board1[row, column]);
                    Console.Write(" | ");

                }
                Console.WriteLine();
                Console.WriteLine("-------------");
            }
        }

        public void InitializeBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Board1[row, column] = ' ';
                }
            }
        }

        public bool IfFull()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    if (this.Board1[row, column] == ' ')
                        return false;
                }
            }
            return true;

        }

    }




}
