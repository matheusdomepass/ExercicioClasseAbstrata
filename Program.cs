using ExercicioClasseAbstrata.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                    employees.Add(new Individual(name, annualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberofEmployees = int.Parse(Console.ReadLine());
                    employees.Add(new Company(name, annualIncome, numberofEmployees));
                }
            }
            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach(Employee emp in employees)
            {
                double tax = emp.Tax();
                Console.WriteLine(emp.Name + ": $" + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }
            Console.WriteLine();
            Console.Write("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}