using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_Almost_Chess___Skrabec
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            while (true)
            {
                board.Display();
                board.AskForCoordinates();
                board.Move();
                Console.Clear();

            }
            
        }
    }
}

