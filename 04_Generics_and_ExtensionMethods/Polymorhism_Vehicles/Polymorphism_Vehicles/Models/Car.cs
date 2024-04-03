namespace Models
{
    public class Car : Vehicle
    {
        public string VehicleType { get; set; }
        public int NumberOfWheels { get; set; }

        public Car(string vehicleType, int numberOfWheels)
        {
            VehicleType = vehicleType;
            NumberOfWheels = numberOfWheels;
        }

        public static void Drive()
        {
            Console.WriteLine("Driving");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"I'm a {VehicleType} and i drive on {NumberOfWheels} wheels :)");
        }
    }
}
