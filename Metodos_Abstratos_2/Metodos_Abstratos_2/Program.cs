using System;
using System.Collections.Generic;
using Metodos_Abstratos_2.Entities;
using System.Globalization;

namespace Metodos_Abstratos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.WriteLine("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:" );
                
                Console.WriteLine("Individual or Company (i/c)? ");
                char type = char.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(type == 'i')
                {
                    Console.WriteLine("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, income, healthExpenditures));
                }
                else
                {
                    Console.WriteLine("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, income, numberOfEmployees));
                }


            }

            double sum = 0.0;
            Console.WriteLine();

            Console.WriteLine("TAXES PAID: ");
            foreach(TaxPayer tp in list)
            {
                double tax = tp.Tax();
                Console.WriteLine(tp.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
