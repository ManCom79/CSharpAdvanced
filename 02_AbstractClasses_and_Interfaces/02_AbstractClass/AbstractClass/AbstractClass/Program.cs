using Models;

namespace AbstractClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Manager man1 = new Manager(employees.Count(), "John", "Johnson", "R&D", "Manager", 1500, 1.25);
            employees.Add(man1);

            Programmer prog1 = new Programmer(employees.Count(), "Ana", "Annson", "R&D", "Programmer", "Junior", 1500);
            employees.Add(prog1);
            Programmer prog2 = new Programmer(employees.Count(), "George", "Enson", "R&D", "Programmer", "Medior", 1500);
            employees.Add(prog2);
            Programmer prog3 = new Programmer(employees.Count(), "Harry", "Mason", "R&D", "Programmer", "Senior", 1500);
            employees.Add(prog3);

            Console.WriteLine(man1.DisplayInfo());
            Console.WriteLine(prog1.DisplayInfo());
            Console.WriteLine(prog2.DisplayInfo());
            Console.WriteLine(prog3.DisplayInfo());


        }
    }
}
