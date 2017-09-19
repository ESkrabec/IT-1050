using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring Variables //

            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            System.Console.WriteLine("What is your first name?");
            firstName = System.Console.ReadLine(); // Variable Assignment //

            System.Console.WriteLine("What is your middle initial?");
            middleInitial = System.Console.ReadLine(); // Variable Assignment //

            System.Console.WriteLine("What is your last name?");
            lastName = System.Console.ReadLine(); // Variable Assignment //

            fullName = firstName + " " + middleInitial + ". " + lastName; // Concatenate all three variables to get fullName //

            System.Console.WriteLine("What is the base number of your height in feet?");
            heightFeet = int.Parse(System.Console.ReadLine()); // Variable Assignment //

            System.Console.WriteLine("In inches, how tall are you past your base height in feet?");
            heightInches = double.Parse(System.Console.ReadLine()); // Variable Assignment //

            totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54; // Concatenate and use arithmetic to achieve totalHeightCM //

            System.Console.WriteLine("How old are you?");
            age = int.Parse(System.Console.ReadLine()); // Variable Assignment //

            System.Console.WriteLine("Are you a citizen? If yes, answer true. If no, answer false.");
            isCitizen = bool.Parse(System.Console.ReadLine()); // Variable Assignment, Program will not accept "yes" as an answer because of type bool //

            canVote = isCitizen && age >=18; // Variable Assignment, canVote will only have true outcome if both isCitizen and age >=18 are true. Otherwise, a 'false' outcome will be produced. //

            System.Console.WriteLine("Full Name: " + fullName);

            System.Console.WriteLine("Height (cm): " + totalHeightCM + "cm");

            System.Console.WriteLine("Voter Registration Status: " + canVote);

            System.Console.WriteLine("Press any key to continue...");

            System.Console.ReadKey();

        }
    }
}
