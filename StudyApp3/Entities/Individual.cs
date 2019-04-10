namespace StudyApp3.Entities
{
    class Individual : Contributors
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double yearEarnings, double healthExpenditures) 
            : base(name,yearEarnings)
        {
            HealthExpenditures = healthExpenditures;
        }


        public override double Taxes()
        {
            if (AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            }
            else
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }

        }
    }
}
