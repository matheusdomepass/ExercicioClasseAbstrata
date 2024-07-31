using System;

namespace ExercicioClasseAbstrata.Entities
{
    class Individual : Employee
    {
        public double HealthExpenditures { get; set; }

        public Individual() { }

        public Individual(string name, double annualIncome, double healthExpenditures)
            : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnnualIncome < 2000.0)
            {
                return AnnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return AnnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
