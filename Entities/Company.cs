using System;

namespace ExercicioClasseAbstrata.Entities
{
    class Company : Employee
    {
        public int NumberOfEmployees { get; set; }

        public Company() { }

        public Company(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }

}
