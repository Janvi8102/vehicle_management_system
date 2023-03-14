using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_management_system
{
    public class VehicleActivity
    {
        public void StartTwoWheeler()
        {
            Console.WriteLine("\nStart TwoWheeler: ");
            Console.WriteLine("Start the engine");
            Console.WriteLine("Start Driving");
        }
        public void StopTwoWheeler()
        {
            Console.WriteLine("\nStop TwoWheeler:");
            Console.WriteLine("Stop Driving");
            Console.WriteLine("Stop the engine");
        }
        public void StartFourWheeler()
        {
            Console.WriteLine("\nStart FourWheeler:");
            Console.WriteLine("Start the engine");
            Console.WriteLine("Release hand brake");
            Console.WriteLine("Start Driving");
        }
        public void StopFourWheeler()
        {
            Console.WriteLine("\nStop FourWheeler: ");
            Console.WriteLine("Stop Driving");
            Console.WriteLine("Engage hand brake");
            Console.WriteLine("Stop the engine");
        }
    }
}
