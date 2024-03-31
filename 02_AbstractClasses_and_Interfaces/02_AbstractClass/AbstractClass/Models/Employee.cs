namespace Models
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        public Employee(int id, string firstName, string lastName, string department) {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        public abstract double CalculateSalary();

        public abstract string DisplayInfo();
    }
}
