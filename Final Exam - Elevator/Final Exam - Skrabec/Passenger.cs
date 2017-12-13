using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam___Skrabec
{
    public class Passenger
    {
        private string Name;
        public double Weight;

        public Passenger(string Name, double Weight)
        {
            this.Name = Name;
            this.Weight = Weight;
        }

        public string GetName()
        {
            return this.Name; 
        }

        public double GetWeight()
        {
            return this.Weight;
        }
    }
}
