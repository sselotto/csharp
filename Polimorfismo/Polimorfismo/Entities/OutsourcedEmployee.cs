using Polimorfismo.Entities;

namespace Polimorfismo.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        //Construtor main
        public OutsourcedEmployee() 
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalcharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalcharge;
        }



        public override double Payment()
        {
            return base.Payment() + 1.10 * AdditionalCharge;
        }

    }
}
