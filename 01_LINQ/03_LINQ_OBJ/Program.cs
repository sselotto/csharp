using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_LINQ_OBJ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> lista = new List<Usuario>();

            lista.Add(new Usuario() { Nome = "José", Email = "jose@gmail.com" });
            lista.Add(new Usuario() { Nome = "Maria", Email = "maria@hotmail.com" });
            lista.Add(new Usuario() { Nome = "João", Email = "joao@ig.com" });
            lista.Add(new Usuario() { Nome = "Felipe", Email = "felipe@gmail.com" });
            lista.Add(new Usuario() { Nome = "Elias", Email = "elias@gmail.com" });

            //Criar uma variavel utilizando a sintaxe LINQ
            var ListaFiltrada = lista.Where(a => a.Email.Contains("@gmail.com")).OrderBy(a => a.Nome).Select(a => a);

            //Vamos apresentar os valores
            foreach(var item in ListaFiltrada)
            {
                Console.WriteLine(item.Nome + " - " + item.Email);
            }

            Console.ReadKey();
        }
    }
}
