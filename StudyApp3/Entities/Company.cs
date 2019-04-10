namespace StudyApp3.Entities
{
    class Company : Contributors
    {
        public int EmployeeNumber { get; set; }

        public Company(string name, double yearEarnings, int employeeNumber) 
            : base(name, yearEarnings)
        {
            EmployeeNumber = employeeNumber;
        }

        public override double Taxes()
        {
            if(EmployeeNumber > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
