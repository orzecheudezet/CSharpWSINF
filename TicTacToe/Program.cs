using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

            char playOrNot = ' ';

            Board plansza = new Board();
            Console.Write("Enter the first player nick: ");
            string nick1 = Console.ReadLine();
            Console.Write("Enter the secound player nick: ");
            string nick2 = Console.ReadLine();
            Player gracz1 = new Player(nick1, plansza);
            Player gracz2 = new Player(nick2, plansza);

            while(playOrNot != 'n')
            {
                Console.Clear();
                Random rand = new Random((int)DateTime.Now.Ticks);
                int los = rand.Next(2) + 1;
                plansza.InitializeBoard();
                gracz1.ShowScore();
                gracz2.ShowScore();
                Console.WriteLine();


                if (los == 1)
                {
                    Console.WriteLine(gracz1.Nick + " starts a game!");
                    gracz1.SignChoose();
                    if (gracz1.Sign == 'O')
                        gracz2.Sign = 'X';
                    if (gracz1.Sign == 'X')
                        gracz2.Sign = 'O';
                }
                else
                {
                    Console.WriteLine(gracz2.Nick + " starts a game!");
                    gracz2.SignChoose();
                    if (gracz2.Sign == 'O')
                        gracz1.Sign = 'X';
                    if (gracz2.Sign == 'X')
                        gracz1.Sign = 'O';
                }




                Console.Clear();

                if (los == 1)
                {
                    while (true)
                    {
                        plansza.PrintBoard();

                        while (gracz1.IfAdded != true)
                        {
                            gracz1.Move();
                        }
                        gracz1.IfAdded = false;
                        gracz1.CheckIfWin();
                        gracz2.CheckIfWin();
                        Console.Clear();

                        if (gracz1.IfWon == true || gracz2.IfWon == true || plansza.IfFull() == true)
                            break;


                        plansza.PrintBoard();

                        while (gracz2.IfAdded != true)
                        {
                            gracz2.Move();
                        }
                        gracz2.IfAdded = false;

                        gracz1.CheckIfWin();
                        gracz2.CheckIfWin();
                        Console.Clear();

                        if (gracz1.IfWon == true || gracz2.IfWon == true || plansza.IfFull() == true)
                            break;
                    }
                }
                if (los == 2)
                {
                    while (plansza.IfFull() != true)
                    {
                        plansza.PrintBoard();

                        while (gracz2.IfAdded != true)
                        {
                            gracz2.Move();
                        }
                        gracz2.IfAdded = false;

                        gracz1.CheckIfWin();
                        gracz2.CheckIfWin();
                        Console.Clear();

                        if (gracz1.IfWon == true || gracz2.IfWon == true || plansza.IfFull() == true)
                            break;

                        plansza.PrintBoard();

                        while (gracz1.IfAdded != true)
                        {
                            gracz1.Move();
                        }
                        gracz1.IfAdded = false;

                        gracz1.CheckIfWin();
                        gracz2.CheckIfWin();
                        Console.Clear();

                        if (gracz1.IfWon == true || gracz2.IfWon == true || plansza.IfFull() == true)
                            break;
                    }
                }


                if (gracz1.IfWon == true)
                {
                    Console.WriteLine("Player: " + gracz1.Nick + "( " + gracz1.Sign + " )" + " is a winner!");
                    gracz1.ScoreIncrement();
                }
                    
                else if (gracz2.IfWon == true)
                {
                    Console.WriteLine("Player: " + gracz2.Nick + "( " + gracz2.Sign + " )" + " is a winner!");
                    gracz2.ScoreIncrement();
                }
                else
                    Console.WriteLine("It's a draw!");

                plansza.PrintBoard();
                gracz1.RemoveSign();
                gracz2.RemoveSign();
                Console.WriteLine("Do you want to play again?");
                

                
                while (playOrNot != 'y' & playOrNot != 'n')
                {
                    Console.WriteLine("Press y on your keyboard if you want playe again or press n if you want to exit.");
                    playOrNot = Console.ReadKey().KeyChar;
                }

                //Console.ReadKey();

            }
            
            
           

            



            
        }

        
            

    }
}
