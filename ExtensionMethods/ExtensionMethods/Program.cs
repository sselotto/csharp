using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "testando!";

            //Acrescentando um metodo dentro da classe string
            Console.WriteLine(valor.FirsttoUpper());

            Console.ReadKey();
        }
    }
}
