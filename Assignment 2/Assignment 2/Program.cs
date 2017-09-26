using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Spouse = new Person();
            p1.Spouse.Spouse = p1;

            Person p2 = new Person();
            p2.Spouse = new Person();
            p2.Spouse.Spouse = p2;

            System.Console.WriteLine("p1 info: ");
            p1.GetCoupleInfo();
            System.Console.WriteLine("p2 info: ");
            p2.GetCoupleInfo();

            p1.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            p2.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();

            System.Console.WriteLine("Average of ages are: " + Person.SumOfAllAges / 4);

            System.Console.Write("Press any key to continue...");
            System.Console.ReadKey();

        }    
    }
}
