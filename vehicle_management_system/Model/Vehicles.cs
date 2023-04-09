using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_management_system.Model
{
    public class Vehicles
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public int VehicleType { get; init; }
        public int SeatingCapacity { get; init; }
        public int FuelType { get; init; }
        public int FuelTankSize { get; init; }
        public int HeadLightCount { get; init; }
        public int TailLightCount { get; init; }
        public int IndicatorCount { get; init; }
        public int ExhaustCount { get; init; }
        public int WheelsCount { get; init; }

        public void StartVehicle()
        {
            Console.WriteLine("Start the engine");
        }

        public void StopVehicle()
        {
            Console.WriteLine("Stop the engine");
        }
    }
}
 