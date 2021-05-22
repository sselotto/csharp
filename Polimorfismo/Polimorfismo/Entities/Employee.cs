using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee() //Construtor main
        {

        }

        public Employee(string name, int hours, double valuePerHour) //Construtor com argumentos para ter opção para estanciar Employees
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment() //Liberar a operação de pagamento para que possa ser sobrescrita
        {
            return Hours * ValuePerHour;
        }
    }
}
