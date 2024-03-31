using Models;
namespace Polymorphism_Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car("car", 4);
            Vehicle motorBike = new MotorBike("motorbike", 2);
            Vehicle boat = new Boat();
            Vehicle plane = new Plane("Jumbo Jet");

            car.DisplayInfo();
            motorBike.DisplayInfo();
            boat.DisplayInfo();
            plane.DisplayInfo();
        }
    }
}
