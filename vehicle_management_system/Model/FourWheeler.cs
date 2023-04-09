using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_management_system.Model
{
    public class FourWheeler : Vehicles
    {
        public int SpeakerCount { get; init; }
        public int WindowCount { get; init; }
        public int SeatBeltCount { get; init; }
        public int DiscBrakeCount { get; init; }

        public void StartFourWheeler()
        {
            StartVehicle();
            Console.WriteLine("Release hand brake");
            Console.WriteLine("Start Driving");
        }

        public void StopFourWheeler()
        {
            Console.WriteLine("Stop Driving");
            Console.WriteLine("Engage hand brake");
           StopVehicle();
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, Name: {1}, Vehicle Type: {2}, Seating Capacity: {3}, Fuel Type: {4}, Fuel Tank Size: {5}, " +
                "HeadLight Count: {6}, TailLight Count: {7},Indicator Count: {8}, Exhaust Count: {9}, Wheels Count: {10}, Speaker Count: {11}," +
                "Window Count: {12}, SeatBelt Count: {13}, DiskBreak Count: {14}\n",
                Id, Name, VehicleType, SeatingCapacity, FuelType, FuelTankSize, HeadLightCount, TailLightCount, IndicatorCount, ExhaustCount,
                WheelsCount, SpeakerCount, WindowCount, SeatBeltCount, DiscBrakeCount);
        }
    }
}
