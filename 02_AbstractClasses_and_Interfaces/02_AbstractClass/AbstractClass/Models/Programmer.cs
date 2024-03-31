namespace Models
{
    public class Programmer : Employee
    {
        public string JobTitle { get; set; }
        int BaseSalary { get; set; }
        string Seniority { get; set; }

        public Programmer(int id, string firstName, string lastName, string department, string jobTitle, string seniority, int baseSalary) : base(id, firstName, lastName, department)
        {
            JobTitle = jobTitle;
            BaseSalary = baseSalary;
            Seniority = seniority;
        }

        public override double CalculateSalary()
        {
            double salary = 0;

            switch (Seniority)
            {
                case "Junior":
                    {
                        salary = BaseSalary * (double)1.15;
                        break;
                    }
                case "Medior":
                    {
                        salary = BaseSalary * (double)1.30;
                        break;
                    }
                case "Senior":
                    {
                        salary = BaseSalary * (double)1.50;
                        break;
                    }
            }
            return Math.Round(salary, 3, MidpointRounding.AwayFromZero);
        }

        public override string DisplayInfo()
        {
            return $"\nEmployee ID: {Id}\nEmployee Name: {FirstName} {LastName}\nDepartment: {Department}\nSeniority: {Seniority}\nSalary: {CalculateSalary()}";
        }
    }
}
