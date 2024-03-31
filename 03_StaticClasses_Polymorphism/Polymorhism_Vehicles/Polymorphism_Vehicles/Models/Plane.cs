namespace Models
{
    public class Plane : Vehicle
    {
        public string VehicleType { get; set; }
        public Plane(string vehicleType)
        {
            VehicleType = vehicleType;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"I'm a {VehicleType} and I have multiple couples of wheels :)");
        }
    }
}
