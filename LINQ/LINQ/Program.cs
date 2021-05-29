using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source

            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression

            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            // Execute the query

            foreach(int x in result)
            {
                Console.WriteLine(x);
            }

            // Where: Filtrar a fonte de dados, gerar uma nova coleção contendo somente dados que atenderem predicados que informa como argumento da função

            // (x => x % 2 == 0) : Predicado que vai dar true somente para numeros pares

            // Select(x => x * 10): Pega cada elemento do resultado que contenha apenas numeros pares e multiplica por 10. Para aplicar uma função a cada 
            // elemento da coleção original gerando uma nova função, com a exp lambda!
        }
    }
}
