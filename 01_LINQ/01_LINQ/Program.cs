using System;
using System.Linq;

namespace _01_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ e LAMBDA
            //LAMBDA = (entrada) => (expressão)
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            //a variavel que vai representar dentro da lista, no Where a > 10, Select expressão do SQL, no caso retornar o elemento da lista, utilizando o comando Order BY
            var listaFiltrada = lista.Where(a => a > 10).OrderBy(a => a).Select(a => a); 

            foreach(var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
