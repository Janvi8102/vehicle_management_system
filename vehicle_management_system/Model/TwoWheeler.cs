using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace vehicle_management_system.Model
{
    public class TwoWheeler : Vehicles
    {
        public int NoOfHelmet { get; init; }

        public void StartTwoWheeler()
        {
            StartVehicle();
            Console.WriteLine("Start Driving");
        }

        public void StopTwoWheeler()
        {
            Console.WriteLine("Stop Driving");
            StopVehicle();
        }

        public override string ToString()
        {
            return string.Format( "Id: {0}, Name: {1}, Vehicle Type: {2}, Seating Capacity: {3}, Fuel Type: {4}, Fuel Tank Size: {5}, " +
                "HeadLight Count: {6}, TailLight Count: {7},Indicator Count: {8}, Exhaust Count: {9}, Wheels Count: {10}, NoOfHelmet: {11}\n",
                Id, Name, VehicleType, SeatingCapacity, FuelType, FuelTankSize, HeadLightCount, TailLightCount, IndicatorCount, ExhaustCount, 
                WheelsCount, NoOfHelmet);
        }

    }
}
