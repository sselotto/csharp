using System;
using System.Collections.Generic;

namespace HashSet_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aplicando o Conjunto HashSet

            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            // Vai percorrer os elementos do conjunto, porem fazendo interação entre os elementos de forma interna conforme implementado no conjunto!

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }

            //Aplicando o Conjunto SortedSet

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            PrintCollection(a);
            PrintCollection(b);

            //Conjunto UNION

            SortedSet<int> c = new SortedSet<int>(a); // Estou instanciando um novo conjunto c e inserindo todos os elementos do conjunto a
            c.UnionWith(b); //Uniao de c com b, ou seja, vou inserir dentro do conjunto c todos os elementos de b que não esteja em c, não pode ter repetição!
            PrintCollection(c);

            //Conjunto INTERSECTION

            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //Conjunto DIFFERENCE

            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);


        }

        // Uma interface IEnumerable inplementada por todas as coleções basicas do pacote System.Collections
        // A collection que recebe como argumento é uma coleção do tipo T que implementa o IEnumerable, com isso posso implementar o foreach

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");
              
            }
            Console.WriteLine();
        }
         
    }
}
