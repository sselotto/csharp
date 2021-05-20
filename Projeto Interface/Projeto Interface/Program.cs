using System;
using System.Globalization;
using Projeto_Interface.Model.Entidades;



namespace Projeto_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IForma s1 = new Circulo() { Raio = 2.0, Cor = Cor.Branco };
            IForma s2 = new Retangulo() { Largura = 3.5, Altura = 4.2, };

            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
