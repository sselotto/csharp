using System;
using System.Globalization;

namespace Projeto_Interface.Model.Entidades
{
    class Retangulo
    {
        public double Largura { get; set; };
        public double Altura { get; set; };

        public override double Area()
        {
            return Largura * Altura;
        }

        public override string ToString()
        {
            return "Cor do Retangulo = "
                + Cor
                + ", Largura = "
                + Largura.ToString("F2", CultureInfo.InvariantCulture)
                + ", Altura = "
                + Altura.ToString("F2", CultureInfo.InvariantCulture)
                + Area.Tostring("F2", CultureInfo.InvariantCulture);
                
        }
    }
}
