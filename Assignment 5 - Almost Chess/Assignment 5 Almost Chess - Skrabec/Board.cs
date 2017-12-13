using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_Almost_Chess___Skrabec
{
    public class Board
    {
        int tx = 0;
        int ty = 0;
        int dx = 0;
        int dy = 0;


        string[][] board;

        public Board()
        {
            board = new string[8][]; 

            for (int x = 0; x < 8; x++)
            {
                board[x] = new string[8];

                for (int y = 0; y < 8; y++)
                {
                    if (x < 2 || x > 5)
                    {
                        board[x][y] = " X "; 
                    }
                    else
                    {
                        board[x][y] = " . ";
                    }
                }
            }
        }

        public void Display()
        {
            for (int x = 0; x < 8; x++)
            {
                Console.WriteLine();
                for (int y = 0; y < 8; y++)
                {
                    Console.Write(board[x][y]);
                }
            }
        }

        public void AskForCoordinates()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("  Enter X Coordinate of peice you would like to move: ");
            tx = int.Parse(Console.ReadLine());
            Console.Write("  Enter Y Coordinate of peice you would like to move: ");
            ty = int.Parse(Console.ReadLine());
            Console.Write("  Enter X Coordinate of where you would like to move to: ");
            dx = int.Parse(Console.ReadLine());
            Console.Write("  Enter Y Coordinate of where you would like to move to: ");
            dy = int.Parse(Console.ReadLine());


        }

        public void Move()
        {

            board[dx][dy] = board[tx][ty];
            board[tx][ty] = " . "; 
        }


    }
}
        
    

        
    
