namespace Models
{
    public class MotorBike : Vehicle
    {
        public string VehicleType { get; set; }
        public int NumberOfWheels { get; set; }

        public MotorBike(string vehicleType, int numberOfWheels)
        {
            VehicleType = vehicleType;
            NumberOfWheels = numberOfWheels;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"I'm a {VehicleType} and i drive on {NumberOfWheels} wheels :)");
        }
    }
}
