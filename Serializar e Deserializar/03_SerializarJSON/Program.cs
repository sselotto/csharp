using System;
using _00_Biblioteca;
using System.IO;
using Nancy.Json;

namespace _03_SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Maria Costa Silva", CPF = "333.222.333-10", Email = "Maria@gmail.com" };

            //Vamos Serializar
            JavaScriptSerializer serializador = new JavaScriptSerializer();

            string stringobjserializado = serializador.Serialize(usuario); //Retorna uma string

            StreamWriter sw = new StreamWriter(@"C:\Users\SAMIR\Documents\Arquivo C# Avançado\02_SerializarJSON.json");
            Console.WriteLine(stringobjserializado);
            sw.Close();

        }
    }
}
