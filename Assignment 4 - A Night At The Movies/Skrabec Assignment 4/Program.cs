using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkrabecAssignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMovieOptions();
            string option = Console.ReadLine();

            int child = 0;
            int adult = 0;
            int senior = 0; 
            double TicketCost = 0;
            double ConcessionCost = 0;
            double Discounts = 0;
            int min; 
            double TotalCost; 

            if (option == "1")
            {
                Console.WriteLine("How many child tickets are needed?");
                child = int.Parse(Console.ReadLine());
                Console.WriteLine("How many adult tickets are needed?");
                adult = int.Parse(Console.ReadLine());
                Console.WriteLine("How many senior tickets are needed?");
                senior = int.Parse(Console.ReadLine());
                TicketCost = child * 3.99 + adult * 5.99 + senior * 4.50;
            }
            else if (option == "2")
            {
                Console.WriteLine("How many child tickets are needed?");
                child = int.Parse(Console.ReadLine());
                Console.WriteLine("How many adult tickets are needed?");
                adult = int.Parse(Console.ReadLine());
                Console.WriteLine("How many senior tickets are needed?");
                senior = int.Parse(Console.ReadLine());
                TicketCost = child * 6.99 + adult * 10.99 + senior * 8.50;
            }

            Console.WriteLine("How many small sodas would you like?");
            int soda = int.Parse(Console.ReadLine());
            Console.WriteLine("How many large sodas would you like?");
            int Soda = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hot dogs would you like?");
            int Hotdog = int.Parse(Console.ReadLine());
            Console.WriteLine("How many orders of popcorn would you like?");
            int Popcorn = int.Parse(Console.ReadLine());
            Console.WriteLine("How many pieces of candy would you like?");
            int Candy = int.Parse(Console.ReadLine());
            ConcessionCost = soda * 3.50 + Soda * 5.99 + Hotdog * 3.99 + Popcorn * 4.50 + Candy * 1.99;
   
            min = (Popcorn < Soda) ? Popcorn : Soda; 
            Discounts = min * 2;

            if (child + adult + senior >= 3 && Popcorn >= 1)
            {
                Discounts += 4.50;
            }

            if (Candy >= 4) 
            {
                
                Discounts += Candy / 4 * 1.99; 
            }

            Console.WriteLine();
            Console.WriteLine("Wow, you saved" + " " + Discounts + " " + "tonight!");

            Console.WriteLine(); 
            TotalCost = TicketCost + ConcessionCost - Discounts;
            Console.WriteLine("Your total comes to" + " " + TotalCost + "," + " " + "enjoy the movie!");

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void ShowMovieOptions()
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("  1: Matinee time (Enter 1) ");
            Console.WriteLine("  2: Evening time (Enter 2) ");
        }
    }
}

