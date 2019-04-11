using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        public Player(string playerNick, Board board)
        {
            this.Board = board;
            Nick = playerNick;
            
        }
        public char Sign;
        public string Nick;
        private Board Board;
        public bool IfAdded = false;
        public bool IfWon = false;
        private int Score = 0;


        public void ScoreIncrement()
        {
            this.Score++;
        }

        public void ShowScore()
        {
            Console.WriteLine(this.Nick + " :" + this.Score);
        }

        public void SignChoose()
        {

            while (this.Sign != 'X' & this.Sign != 'O')
            {
                Console.WriteLine(this.Nick + "! Choose your sign!");
                Console.WriteLine("Press x on your keyboard if you wanto to be an X or press o to be an O.");
                char playerInput = Console.ReadKey().KeyChar;
                if (playerInput == 'x' || playerInput == 'X')
                    this.Sign = 'X';
                if (playerInput == 'o' || playerInput == 'O')
                    this.Sign = 'O';
            }
        }
        public void RemoveSign()
        {
            this.Sign = ' ';
        }

        public bool Move()
        {
            Movement movement = new Movement();
            movement.Move();

            if (movement.CursorX == 2 & movement.CursorY == 0)
                if (this.Board.Board1[0, 0] == ' ')
                {
                    this.Board.Board1[0, 0] = this.Sign;
                    return this.IfAdded = true;
                }
                else
                {
                    return this.IfAdded = false;
                }

            else if (movement.CursorX == 6 & movement.CursorY == 0)
                if (this.Board.Board1[0, 1] == ' ')
                {
                    this.Board.Board1[0, 1] = this.Sign;
                    return this.IfAdded = true;
                }
                else
                {
                    return this.IfAdded = false;
                }


            else if (movement.CursorX == 10 & movement.CursorY == 0)
                if (this.Board.Board1[0, 2] == ' ')
                {
                    this.Board.Board1[0, 2] = this.Sign;
                    return this.IfAdded = true;
                }
                else
                {
                    return this.IfAdded = false;
                }

            else if (movement.CursorX == 2 & movement.CursorY == 2)
                if (this.Board.Board1[1, 0] == ' ')
                {
                    this.Board.Board1[1, 0] = this.Sign;
                    return this.IfAdded = true;
                }
                else
                {
                    return this.IfAdded = false;
                }

            else if (movement.CursorX == 6 & movement.CursorY == 2)
                if (this.Board.Board1[1, 1] == ' ')
                {
                    this.Board.Board1[1, 1] = this.Sign;
                    return this.IfAdded = true;
                }
                else
                {
                    return this.IfAdded = false;
                }

            else if (movement.CursorX == 10 & movement.CursorY == 2)
                if (this.Board.Board1[1, 2] == ' ')
                {
                    this.Board.Board1[1, 2] = this.Sign;
                    return this.IfAdded = true;
                }
                else
                {
                    return this.IfAdded = false;
                }
            else if (movement.CursorX == 2 & movement.CursorY == 4)
                if (this.Board.Board1[2, 0] == ' ')
                {
                    this.Board.Board1[2, 0] = this.Sign;
                    return this.IfAdded = true;
                }
                else
                {
                    return this.IfAdded = false;
                }
            else if (movement.CursorX == 6 & movement.CursorY == 4)
                if (this.Board.Board1[2, 1] == ' ')
                {
                    this.Board.Board1[2, 1] = this.Sign;
                    return this.IfAdded = true;
                }
                else
                {
                    return this.IfAdded = false;
                }
            else if (movement.CursorX == 10 & movement.CursorY == 4)
                if (this.Board.Board1[2, 2] == ' ')
                {
                    this.Board.Board1[2, 2] = this.Sign;
                    return this.IfAdded = true;
                }
                else
                {
                    return this.IfAdded = false;
                }
            else
                return this.IfAdded = false;
                


        }

        public bool CheckIfWin()
        {
            if (this.Board.Board1[0, 0] == this.Sign & this.Board.Board1[0, 1] == this.Sign & this.Board.Board1[0, 2] == this.Sign)
                return this.IfWon = true;
            else if (this.Board.Board1[1, 0] == this.Sign & this.Board.Board1[1, 1] == this.Sign & this.Board.Board1[1, 2] == this.Sign)
                return this.IfWon = true;
            else if (this.Board.Board1[2, 0] == this.Sign & this.Board.Board1[2, 1] == this.Sign & this.Board.Board1[2, 2] == this.Sign)
                return this.IfWon = true;
            else if (this.Board.Board1[0, 0] == this.Sign & this.Board.Board1[1, 0] == this.Sign & this.Board.Board1[2, 0] == this.Sign)
                return this.IfWon = true;
            else if (this.Board.Board1[0, 1] == this.Sign & this.Board.Board1[1, 1] == this.Sign & this.Board.Board1[2, 1] == this.Sign)
                return this.IfWon = true;
            else if (this.Board.Board1[0, 2] == this.Sign & this.Board.Board1[1, 2] == this.Sign & this.Board.Board1[2, 2] == this.Sign)
                return this.IfWon = true;
            else if (this.Board.Board1[0, 0] == this.Sign & this.Board.Board1[1, 1] == this.Sign & this.Board.Board1[2, 2] == this.Sign)
                return this.IfWon = true;
            else if (this.Board.Board1[0, 2] == this.Sign & this.Board.Board1[1, 1] == this.Sign & this.Board.Board1[2, 0] == this.Sign)
                return this.IfWon = true;
            else
                return this.IfWon = false;
        }       

    }
}
