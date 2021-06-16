using System;
using System.Linq;

namespace _05_LINQ_GROUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ListaNum = { 1, 1, 1, 1, 4, 4, 2, 3, 5, 6, 6, 10, 9, 8 };

            //Group - Distinct
            var listaFiltrada = ListaNum.Distinct().OrderBy(a => a).Select(a => a);

            //var listaFiltrada = ListaNum.OrderBy(a => a).GroupBy(a => a).Select(a => a); //Primeiro faz o ordenamento e posteriormente o group by e Select

            //var listaFiltrada = ListaNum.OrderBy(a => a);

            foreach(var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
