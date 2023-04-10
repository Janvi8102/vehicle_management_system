using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using vehicle_management_system;
using vehicle_management_system.Model;

public class Program
{
    public static void Main(string[] args)
    {
        TwoWheeler Access = new TwoWheeler
        {
            Id = 1,
            Name = "Access",
            VehicleType = VehicleType.TwoWheeler,
            SeatingCapacity = 2,
            FuelTankSize = 3,
            HeadLightCount = 1,
            IndicatorCount = 2,
            ExhaustCount = 1,
            NoOfHelmet = 2,
            WheelsCount = 2
        };

        TwoWheeler Activa5g = new TwoWheeler
        {
            Id = 2,
            Name = "Activa5g",
            VehicleType = VehicleType.TwoWheeler,
            SeatingCapacity = 2,
            FuelTankSize = 3,
            HeadLightCount = 1,
            IndicatorCount = 2,
            ExhaustCount = 1,
            NoOfHelmet = 2,
            WheelsCount = 2
        };

        TwoWheeler Jupiter = new TwoWheeler
        {
            Id = 3,
            Name = "Jupiter",
            VehicleType = VehicleType.TwoWheeler,
            SeatingCapacity = 2,
            FuelTankSize = 3,
            HeadLightCount = 1,
            IndicatorCount = 2,
            ExhaustCount = 1,
            NoOfHelmet = 2,
            WheelsCount = 2
        };

        FourWheeler Scorpio = new FourWheeler
        {
            Id = 4,
            Name = "Scorpio",
            VehicleType = VehicleType.FourWheeler,
            SeatingCapacity = 2,
            FuelType = FuelType.Diesel,
            FuelTankSize = 60,
            HeadLightCount = 2,
            IndicatorCount = 4,
            ExhaustCount = 2,
            WheelsCount = 4,
            SpeakerCount = 2,
            WindowCount = 4,
            SeatBeltCount = 4,
            DiscBrakeCount = 2
        };

        FourWheeler Nexon = new FourWheeler
        {
            Id = 5,
            Name = "Nexon",
            VehicleType = VehicleType.FourWheeler,
            SeatingCapacity = 2,
            FuelType = FuelType.Diesel,
            FuelTankSize = 55,
            HeadLightCount = 2,
            IndicatorCount = 4,
            ExhaustCount = 2,
            WheelsCount = 4,
            SpeakerCount = 3,
            WindowCount = 4,
            SeatBeltCount = 4,
            DiscBrakeCount = 2
        };

        FourWheeler Ciaz = new FourWheeler
        {
            Id = 6,
            Name = "Ciaz",
            VehicleType = VehicleType.FourWheeler,
            SeatingCapacity = 2,
            FuelType = FuelType.Diesel,
            FuelTankSize = 55,
            HeadLightCount = 2,
            IndicatorCount = 4,
            ExhaustCount = 2,
            WheelsCount = 4,
            SpeakerCount = 3,
            WindowCount = 4,
            SeatBeltCount = 4,
            DiscBrakeCount = 2
        };

        Console.WriteLine(Access.ToString());
        Console.WriteLine(Activa5g.ToString());
        Console.WriteLine(Jupiter.ToString());
        Console.WriteLine(Scorpio.ToString());
        Console.WriteLine(Nexon.ToString());
        Console.WriteLine(Ciaz.ToString());

        TwoWheeler driveTwoWheeler = new TwoWheeler();
        driveTwoWheeler.StartTwoWheeler();
        driveTwoWheeler.StopTwoWheeler();

        FourWheeler driveFourWheeler = new FourWheeler();
        driveFourWheeler.StartFourWheeler();
        driveFourWheeler.StopFourWheeler();

        //Console.WriteLine(JsonConvert.SerializeObject(Access) + "\n");
        //Console.WriteLine(JsonConvert.SerializeObject(Activa5g) + "\n");
        //Console.WriteLine(JsonConvert.SerializeObject(Jupiter) + "\n");
        //Console.WriteLine(JsonConvert.SerializeObject(Scorpio) + "\n");
        //Console.WriteLine(JsonConvert.SerializeObject(Nexon) + "\n");
        //Console.WriteLine(JsonConvert.SerializeObject(Ciaz) + "\n");
    }
}

