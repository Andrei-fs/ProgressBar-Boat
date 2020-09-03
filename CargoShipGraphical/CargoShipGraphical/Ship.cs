using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShipGraphical
{
    class Ship
    {
        
        //constructor

        public Ship()
        {
            CycleCount = 0;
            CarCount = 0;
            TruckCount = 0;
            TrainCarCount = 0;


            Capacity = random.Next(MaxWeight) * CycleWeight + random.Next(MaxWeight)* CarWeight + random.Next(MaxWeight) *TruckWeight+ random.Next(MaxWeight)*TrainWeight;
        }



        //consts (weights)

        const int CycleWeight = 3;
        const int CarWeight = 5;
        const int TruckWeight = 11;
        const int TrainWeight = 17;

        const int MaxWeight = 10;

        //props 
        public int Capacity { get; set; }
        public int CycleCount { get; set; }
        public int CarCount { get; set; }
        public int TruckCount { get; set; }
        public int TrainCarCount { get; set; }

        Random random = new Random();

        public int GetShipLoad()
        {
            //calculate the total weight of the cargo 

            return CycleCount * CycleWeight + CarCount * CarWeight + TruckCount * TruckWeight + TrainCarCount * TrainWeight;

        }

        public int OverUnder()
        {
            //return the value of the load in the ship

            return Capacity - GetShipLoad();

        }

        public override string ToString()
        {
            return "Capacity = " + Capacity + ", Current Load " + GetShipLoad();
        }
    }
}
