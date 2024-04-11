using Database;
using System;
using System.Globalization;
using System.Reflection;

namespace Advanced_LINQ_and_Anonymous_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Filter all cars that have origin from Europe and print them in console.
            Console.WriteLine("******************** Task 01 (\"********************");
            List<Car> origin = CarsData.Cars.Where(x => x.Origin == "Europe").ToList();
            foreach (Car car in origin)
            {
                Console.WriteLine($"{car.Model} is produced in {car.Origin}");
            }

            //Filter all cars that have more than 6 Cylinders not including 6, after that Filter all cars that have exactly 4 Cylinders and have HorsePower more than 110.0. Join them in one result and print them in console.
            Console.WriteLine("\n******************** Task 02 (\"********************");
            List<Car> moreThanSixCylinders = CarsData.Cars.Where(x => x.Cylinders > 6).ToList();
            List<Car> fourCylinderAndAbove110HP = CarsData.Cars.Where(x => x.Cylinders == 4 && x.HorsePower > 110).ToList();
            List<Car> joindLists = new List<Car>();
            joindLists.AddRange(moreThanSixCylinders);
            joindLists.AddRange(fourCylinderAndAbove110HP);
            foreach (Car car in joindLists)
            {
                if(car.Cylinders > 6)
                {
                    Console.WriteLine($"{car.Model} has more than 6 cylinders. It has {car.Cylinders}.");
                } else
                {
                    Console.WriteLine($"{car.Model} has exactly {car.Cylinders} cylinders and {car.HorsePower}HP.");
                }
            }

            //Count all cars based on their Origin and print the result in console. Example outpur "US 10 models\n Eu 15 Models";
            Console.WriteLine("\n******************** Task 03 ********************");
            var origins = CarsData.Cars.GroupBy(x => x.Origin);
            foreach(var carOrigin in origins)
            {
                Console.WriteLine($"{carOrigin.Key} - {carOrigin.Count()} models");
            }

            //Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highes and average Miles per galon and print them in console;
            Console.WriteLine("\n******************** Task 04 ********************");
            List<Car> above200 = CarsData.Cars.Where(x => x.HorsePower > 200).ToList();

            double minMilagePerGalon = CarsData.Cars.Where(x => x.HorsePower > 200).Select(x => x.MilesPerGalon).Min();
            Console.WriteLine($"Minimum milege per galon for cars that have >200 HP is {minMilagePerGalon}");

            double maxMilagePerGalon = CarsData.Cars.Where(x => x.HorsePower > 200).Select(x => x.MilesPerGalon).Max();
            Console.WriteLine($"Maximum milege per galon for cars that have >200 HP is {maxMilagePerGalon}");

            double averageMilagePerGalon = CarsData.Cars.Where(x => x.HorsePower > 200).Select(x => x.MilesPerGalon).Average();
            Console.WriteLine($"Average milege per galon for cars that have >200 HP is {averageMilagePerGalon}");

            //Find the top 3 fastest accelerating cars. Order cars by their AccelerationTime in ascending order. Take the top 3 cars from the ordered list. Print the model of each of these top 3 cars.
            Console.WriteLine("\n******************** Task 05 ********************");
            List<Car> orederedByAccelaration = CarsData.Cars.OrderBy(x => x.AccelerationTime).Take(3).ToList();
            foreach(Car car in orederedByAccelaration)
            {
                Console.WriteLine($"{car.Model} has {car.AccelerationTime} acceleration");
            }

            //Filter cars that have more than 6 cylinders. Calculate the total weight of these cars. Print the total weight.
            Console.WriteLine("\n******************** Task 06 ********************");
            double moreThanSixCylinders01 = CarsData.Cars.Where(x => x.Cylinders > 6).Sum(x => x.Weight);
            Console.WriteLine($"The total weight of the cars that have more than 6 cylinders is {moreThanSixCylinders01} units of weight.");

            //Find the average MilesPerGalon for cars with even number of cylinders
            Console.WriteLine("\n******************** Task 07 ********************");
            double avgMpgOfEvenCylinders = CarsData.Cars.Where(x => x.Cylinders % 2 == 0).Average(x => x.MilesPerGalon);
            Console.WriteLine($"Average miles per galon for cars that have even number of cyliders is {avgMpgOfEvenCylinders}");

            ////Control calculations:
            //List<Car> withEven = CarsData.Cars.Where(x => x.Cylinders % 2 == 0).ToList();
            //Console.WriteLine($"There are {withEven.Count()} cars with even numer of cylinders. They are: ");
            //double summpg = CarsData.Cars.Where(x => x.Cylinders % 2 == 0).Sum(x => x.MilesPerGalon);
            //Console.WriteLine($"Sum of miles per galon is {summpg}");
        }
    }
}
