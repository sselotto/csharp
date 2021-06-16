using System;
using System.IO;
using _00_Biblioteca;
using Nancy.Json;

namespace _04_DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\SAMIR\Documents\Arquivo C# Avançado\02_SerializarJSON.json");
            string linhasdoarquivo = stream.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();

            Usuario usuario = (Usuario) serializador.Deserialize(linhasdoarquivo, typeof(Usuario)); //Criando uma variavel Usuario que vai receber objeto, necessario fazer um casting

            Console.WriteLine("Usuario(Nome): {0}, CPF: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);

            Console.ReadKey();

            //Deserialize - retorna um objeto, com isso a necessidade de utilização do Casting
        }
    }
}
