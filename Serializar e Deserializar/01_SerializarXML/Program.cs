using System;
using System.IO; //Escrita e Leitura de arquivos
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _01_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "José Costa Silva", CPF = "222.222.222-22", Email = "jose@gmail.com" };

            //Instaciar o objeto de Serialização!

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            // XmlSerializer serializar = new XmlSerializer(usuario.GetType()); //Pode utilizar essa opção ou a de cima

            StreamWriter stream = new StreamWriter(@"C:\Users\SAMIR\Documents\Arquivo C# Avançado\01_SerializarXML.xml"); //Criamos o Stream

            serializador.Serialize(stream, usuario); 
        }
    }
}
