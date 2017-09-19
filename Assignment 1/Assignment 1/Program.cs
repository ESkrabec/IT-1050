using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("What is your first name?");
            string firstName = System.Console.ReadLine(); // Variable Assignment //

            System.Console.WriteLine("What is your middle initial?");
            string middleInitial = System.Console.ReadLine(); // Variable Assignment //

            System.Console.WriteLine("What is your last name?");
            string lastName = System.Console.ReadLine(); // Variable Assignment //

            string fullName = firstName + " " + middleInitial + ". " + lastName; // Concatenate all three variables to get fullName //

            System.Console.WriteLine("What is the base number of your height in feet?");
            int heightFeet = int.Parse(System.Console.ReadLine()); // Variable Assignment //

            System.Console.WriteLine("In inches, how tall are you past your base height in feet?");
            double heightInches = double.Parse(System.Console.ReadLine()); // Variable Assignment //

            double totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54; // Concatenate and use arithmetic to achieve totalHeightCM //

            System.Console.WriteLine("How old are you?");
            int age = int.Parse(System.Console.ReadLine()); // Variable Assignment //

            System.Console.WriteLine("Are you a citizen? If yes, answer true. If no, answer false.");
            bool isCitizen = bool.Parse(System.Console.ReadLine()); // Variable Assignment, Program will not accept "yes" as an answer because of type bool //

            bool canVote = isCitizen && age >=18; // Variable Assignment, canVote will only have true outcome if both isCitizen and age >=18 are true. Otherwise, a 'false' outcome will be produced. //

            System.Console.WriteLine("Full Name: " + fullName);

            System.Console.WriteLine("Height (cm): " + totalHeightCM + "cm");

            System.Console.WriteLine("Voter Registration Status: " + canVote);

            System.Console.WriteLine("Press any key to continue...");

            System.Console.ReadKey();

        }
    }
}
