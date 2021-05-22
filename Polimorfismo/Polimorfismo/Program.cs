using System;
using System.Collections.Generic;
using Polimorfismo.Entities;
using System.Globalization;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) //Para fazer a leitura dos dados Employees
            {
                Console.WriteLine($"Employee #{i} data: "); //Utilizando Interpolação
                Console.Write("Outsourceed (y/n)?  ");

                char ch = char.Parse(Console.ReadLine()); //Resposta do usuario para verificar se é tercerizado

                Console.Write("Name: ");
                String name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("ValuePerHour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Fazer um teste

                if (ch == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Chamar a Lista
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));

                }
                //Para instaciar Employee e adicionar na lista caso seja um Employee normal, ou seja, não tercerizado!
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }
                Console.WriteLine();
                Console.WriteLine("PAYMENTS: ");

                //percorrer a lista
                foreach(Employee emp in list)
                {
                    Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                }



            
        }
    }
}
