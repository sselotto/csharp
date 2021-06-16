using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_LINQ_JOIN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Autor> listaAutor = new List<Autor>();

            listaAutor.Add(new Autor() { Id = 1, Nome = "Leonardo" });
            listaAutor.Add(new Autor() { Id = 2, Nome = "Maria" });
            listaAutor.Add(new Autor() { Id = 3, Nome = "Joseph" });

            List<Livro> listaLivro = new List<Livro>();

            listaLivro.Add(new Livro() { Id = 1, AutorId = 2, Titulo = "Amor Amado" });
            listaLivro.Add(new Livro() { Id = 2, AutorId = 2, Titulo = "Bem Amado" });
            listaLivro.Add(new Livro() { Id = 3, AutorId = 3, Titulo = "Um Espião em Washigton" });
            listaLivro.Add(new Livro() { Id = 4, AutorId = 1, Titulo = "A Vida na Terra" });

            //A clausula on server para junção
            var ListaJoin = from Livros in listaLivro join autor in listaAutor on Livros.AutorId equals autor.Id select new { Livros, autor };

            foreach(var item in ListaJoin)
            {

                Console.WriteLine("Livro: " + item.Livros.Titulo + " - Autor: " + item.autor.Nome);
            }

            Console.ReadKey();
        }
    }
}
