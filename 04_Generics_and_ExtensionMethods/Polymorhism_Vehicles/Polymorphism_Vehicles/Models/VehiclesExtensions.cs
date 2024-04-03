namespace Models
{
    public static class VehiclesExtensions
    {
        public static string Drive(this Car car)
        {
            return $"Driving";
        }
        public static string Wheelie(this MotorBike motorBike)
        {
            return $"Driving on one wheel";
        }
        public static string Saling(this Boat boat)
        {
            return $"Sailing";
        }
        public static string Fly(this Plane plane)
        {
            return $"Flying";
        }
    }
}
