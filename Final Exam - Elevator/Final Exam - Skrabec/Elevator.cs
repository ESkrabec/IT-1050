using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam___Skrabec
{
    public class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;
        
        public Elevator(int MaxOccupants, double MaxWeight)
        {
            Occupants = new Passenger[MaxOccupants];
            this.MaxWeight = MaxWeight;
        }
       
        public void AddOccupant(Passenger passenger, int Index)
        {
            Occupants[Index] = passenger;   
        }

        public double GetCurrentWeight()
        {
            double total = 0;
            for (int i = 0; i< Occupants.Length;i++)
            {
                total += Occupants[i].Weight;  
            }
            return total; 
        }

        public bool IsOverMaxCapacity()
        {
            if (GetCurrentWeight() > MaxWeight)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
