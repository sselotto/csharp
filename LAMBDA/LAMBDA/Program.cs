using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using LAMBDA.Entities;

namespace LAMBDA
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>(); //Instaciar uma lista de produtos

            using (StreamReader sr = File.OpenText(path)) //Ler o arquivo de entrada
            {
                while (!sr.EndOfStream) //Enquanto não chegar no final do arquivo vou mandar ler o arquivo
                {
                    string[] fields = sr.ReadLine().Split(','); //Função Split para dividir com base no carater virgula
                    string name = fields[0];

                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price)); //Inserir um novo produto na lista com seu respectivo nome e preço 
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average(); //Função auxiliar DefaultIfEmpty (Caso lista tenha valor zero)

            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name); //Expressão Lambda

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}