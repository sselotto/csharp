using System;
using System.Linq;

namespace _02_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ e LAMBDA
            //LAMBDA = (entrada) => (expressão)
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };


            //var listaFiltrada = lista.Where(a => a > 10).OrderBy(a => a).Select(a => a); //Utiliza-se atráves de Metodos

            var listaFiltrada = from a in lista where a > 10 orderby a select a; //Utiliza-se uma forma literal

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
