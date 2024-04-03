using Models;
namespace Polymorphism_Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("car", 4);
            MotorBike motorBike = new MotorBike("motorbike", 2);
            Boat boat = new Boat();
            Plane plane = new Plane("Jumbo Jet");

            car.DisplayInfo();
            motorBike.DisplayInfo();
            boat.DisplayInfo();
            plane.DisplayInfo();

            Console.WriteLine("\nPrinted from extension methods:");
            Console.WriteLine(car.Drive());
            Console.WriteLine(motorBike.Wheelie());
            Console.WriteLine(boat.Saling());
            Console.WriteLine(plane.Fly());
        }
    }
}
