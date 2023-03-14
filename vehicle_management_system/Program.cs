using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using vehicle_management_system;

public class Program
{
    public static void Main(string[] args)
    {
        TwoWheeler Access = new TwoWheeler();
        Access.Id = 1;
        Access.Name = "Access";
        Access.VehicleType = (int)EnumConstant.VehicleType.TwoWheeler;
        Access.SeatingCapacity = 2;
        Access.FuelType = (int)EnumConstant.FuelType.Petrol;
        Access.FuelTankSize = 3;
        Access.HeadLightCount = 1;
        Access.IndicatorCount = 2;
        Access.ExhaustCount = 1;
        Access.NoOfHelmet = 2;
        Access.WheelsCount = 2;

        TwoWheeler Activa5g = new TwoWheeler();
        Activa5g.Id = 2;
        Activa5g.Name = "Activa5g";
        Activa5g.VehicleType = (int)EnumConstant.VehicleType.TwoWheeler;
        Activa5g.SeatingCapacity = 2;
        Activa5g.FuelType = (int)EnumConstant.FuelType.Petrol;
        Activa5g.FuelTankSize = 3;
        Activa5g.HeadLightCount = 1;
        Activa5g.IndicatorCount = 2;
        Activa5g.ExhaustCount = 1;
        Activa5g.NoOfHelmet = 2;
        Activa5g.WheelsCount = 2;

        TwoWheeler Jupiter = new TwoWheeler();
        Jupiter.Id = 3;
        Jupiter.Name = "Jupiter";
        Jupiter.VehicleType = (int)EnumConstant.VehicleType.TwoWheeler;
        Jupiter.SeatingCapacity = 2;
        Jupiter.FuelType = (int)EnumConstant.FuelType.Petrol;
        Jupiter.FuelTankSize = 3;
        Jupiter.HeadLightCount = 1;
        Jupiter.IndicatorCount = 2;
        Jupiter.ExhaustCount = 1;
        Jupiter.NoOfHelmet = 2;
        Jupiter.WheelsCount = 2;

        FourWheeler Scorpio = new FourWheeler();
        Scorpio.Id = 4;
        Scorpio.Name = "Scorpio";
        Scorpio.VehicleType = (int)EnumConstant.VehicleType.FourWheeler;
        Scorpio.SeatingCapacity = 2;
        Scorpio.FuelType = (int)EnumConstant.FuelType.Diesel;
        Scorpio.FuelTankSize = 60;
        Scorpio.HeadLightCount = 2;
        Scorpio.IndicatorCount = 4;
        Scorpio.ExhaustCount = 2;
        Scorpio.WheelsCount = 4;
        Scorpio.SpeakerCount = 2;
        Scorpio.WindowCount = 4;
        Scorpio.SeatBeltCount = 4;
        Scorpio.DiscBrakeCount = 2;

        FourWheeler Nexon = new FourWheeler();
        Nexon.Id = 5;
        Nexon.Name = "Nexon";
        Nexon.VehicleType = (int)EnumConstant.VehicleType.FourWheeler;
        Nexon.SeatingCapacity = 2;
        Nexon.FuelType = (int)EnumConstant.FuelType.Diesel;
        Nexon.FuelTankSize = 55;
        Nexon.HeadLightCount = 2;
        Nexon.IndicatorCount = 4;
        Nexon.ExhaustCount = 2;
        Nexon.WheelsCount = 4;
        Nexon.SpeakerCount = 3;
        Nexon.WindowCount = 4;
        Nexon.SeatBeltCount = 4;
        Nexon.DiscBrakeCount = 2;

        FourWheeler Ciaz = new FourWheeler();
        Ciaz.Id = 6;
        Ciaz.Name = "Ciaz";
        Ciaz.VehicleType = (int)EnumConstant.VehicleType.FourWheeler;
        Ciaz.SeatingCapacity = 2;
        Ciaz.FuelType = (int)EnumConstant.FuelType.Diesel;
        Ciaz.FuelTankSize = 55;
        Ciaz.HeadLightCount = 2;
        Ciaz.IndicatorCount = 4;
        Ciaz.ExhaustCount = 2;
        Ciaz.WheelsCount = 4;
        Ciaz.SpeakerCount = 3;
        Ciaz.WindowCount = 4;
        Ciaz.SeatBeltCount = 4;
        Ciaz.DiscBrakeCount = 2;

        Console.WriteLine(JsonConvert.SerializeObject(Access)+ "\n");
        Console.WriteLine(JsonConvert.SerializeObject(Activa5g)+ "\n");
        Console.WriteLine(JsonConvert.SerializeObject(Jupiter) + "\n");
        Console.WriteLine(JsonConvert.SerializeObject(Scorpio) + "\n");
        Console.WriteLine(JsonConvert.SerializeObject(Nexon) + "\n");
        Console.WriteLine(JsonConvert.SerializeObject(Ciaz) + "\n");

        VehicleActivity activity = new VehicleActivity();
        activity.StartTwoWheeler();
        activity.StopTwoWheeler();
        activity.StartFourWheeler();
        activity.StopFourWheeler();
    }

  
}

