using System;

namespace ExercicioClasseAbstrata.Entities
{
    abstract class Employee
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Employee() { }

        public Employee(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }
        public abstract double Tax();
    }
}
