using System;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _02_DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\SAMIR\Documents\Arquivo C# Avançado\01_SerializarXML.xml");

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            //Agora vamos deserializar

            Usuario usuario = (Usuario) serializador.Deserialize(stream); //Utilizando Casting

            Console.WriteLine("Usuario(Nome): {0}, CPF: {1} e Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);

            Console.ReadKey(); //Para o programa não seja encerrado
        }
    }
}
