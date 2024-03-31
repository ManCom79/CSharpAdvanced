namespace Models
{
    public class Manager : Employee
    {
        
        public string JobTitle { get; set; }
        int BaseSalary { get; set; }
        double JobComplexity { get; set; }

        public Manager(int id, string firstName, string lastName, string department, string jobTitle, int baseSalary, double jobComplexity) : base(id, firstName, lastName, department)
        {
            JobTitle = jobTitle;
            BaseSalary = baseSalary;
            JobComplexity = jobComplexity;                
        }

        public override double CalculateSalary()
        {
            double salary = BaseSalary * JobComplexity;
            return salary;
        }

        public override string DisplayInfo()
        {
            return $"\nEmployee ID: {Id}\nEmployee Name: {FirstName} {LastName}\nDepartment: {Department}\nJob Title: {JobTitle} Salary: {CalculateSalary()}";
        }
    }
}
