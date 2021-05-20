using System.Globalization;
using System;

namespace Interface_IComparable.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; } // Propriedades

        public Employee(string csvEmployee) // 
        {
            string[] vect = csvEmployee.Split(',');

            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);

        }

        public override string ToString()
        {
            return Name + "," + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) // Compara dois objects e retorna um valor
        {
            if(!(obj is Employee)) //O tipo obj pode ser qualquer coisa
            {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }

            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);

        }
    }
}
