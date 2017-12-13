using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_2_Skrabec
{
    class Person
    {
        public int Age;
        public string firstName;
        public string lastName;
        public Person Spouse;

        public static int SumOfAllAges;
        
        public void GetCoupleInfo()
        {
            System.Console.Write("First Name: ");
            firstName = System.Console.ReadLine();
            System.Console.Write("Last Name: ");
            lastName = System.Console.ReadLine();
            System.Console.Write("Age  : ");
            Age = int.Parse(System.Console.ReadLine());
            System.Console.Write("Spouse Name: ");
            Spouse.firstName = System.Console.ReadLine();
            System.Console.Write("Spouse Age: ");
            Spouse.Age = int.Parse(System.Console.ReadLine());
            Spouse.lastName = lastName;
            SumOfAllAges += Age + Spouse.Age;
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(GetFullName());
            System.Console.WriteLine(Age); 
        }

        
       
    }

}
