using System;
using System.Collections.Generic;
using System.Globalization;
using StudyApp3.Entities;

namespace StudyApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<Contributors> list = new List<Contributors>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employeeNumber = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, employeeNumber));
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0.0;
            foreach(Contributors c in list)
            {
                Console.WriteLine(c.Name + ": $ " + c.Taxes().ToString("F2", CultureInfo.InvariantCulture));
                sum += c.Taxes();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
