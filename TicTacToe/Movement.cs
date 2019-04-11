using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Movement
    {
        public Movement()
        {

        }
        public int CursorXStart = 6;
        public int CursorYStart = 2;
        public int CursorMaxX = 10;
        public int CursorMinX = 2;
        public int CursorMaxY = 4;
        public int CursorMinY = 0;
        public int CursorX;
        public int CursorY;
        ConsoleKeyInfo UserKey;

        public void  Move()
        {
            
            CursorX = CursorXStart;
            CursorY = CursorYStart;

            Console.SetCursorPosition(CursorXStart, CursorYStart);
            
            while (UserKey.Key != ConsoleKey.Enter)
            {
                UserKey = Console.ReadKey(true);
                if (UserKey.Key == ConsoleKey.LeftArrow)
                {
                    if (CursorX > CursorMinX)
                    {
                        
                        this.CursorX -= 4;
                        Console.SetCursorPosition(this.CursorX, this.CursorY);
                    }

                }

                if (UserKey.Key == ConsoleKey.RightArrow)
                {
                    if (CursorX < CursorMaxX)
                    {
                         this.CursorX += 4;
                        Console.SetCursorPosition(this.CursorX, this.CursorY);
                    }

                }
                if (UserKey.Key == ConsoleKey.UpArrow)
                {
                    if (CursorY > CursorMinY)
                    {
                        this.CursorY -= 2;
                        Console.SetCursorPosition(this.CursorX, this.CursorY);
                    }

                }
                if (UserKey.Key == ConsoleKey.DownArrow)
                {
                    if (CursorY < CursorMaxY)
                    {
                        this.CursorY += 2;
                        Console.SetCursorPosition(this.CursorX, this.CursorY);
                        
                    }

                }
            }
            
            
        }
        
    }
}
