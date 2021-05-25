using System;
using System.Collections.Generic;
using Delegates.Entities;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(p => p.Price >= 100.0); //Função Lambda!

            list.RemoveAll(ProductTest);

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }

        }

        public static bool ProductTest(Product p) //Função Delegate Predicate 
        {
            return p.Price >= 100.0;

        }
    }
}
