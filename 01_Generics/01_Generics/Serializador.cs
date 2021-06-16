using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Nancy.Json;


namespace _01_Generics
{
    public class Serializador //Criação dos arquivos e serialização
    {
        //Metodo estatico para não ficar estanciando toda hora
        public static void Serializar(Object obj) //Passar o paramentro ao objeto a ser serializado
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\SAMIR\Documents\Arquivo C# Avançado\03_" + obj.GetType().Name + ".txt");

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objSerializado = serializador.Serialize(obj); //vai armazenar a string 

            sw.Write(objSerializado);
            sw.Close();

        }

        public static T Deserializar<T>() //Vai ter como retorno uma classe especifica e vai chamar de deserializar
        {
            StreamReader sr = new StreamReader(@"C:\Users\SAMIR\Documents\Arquivo C# Avançado\03_"+ typeof(T).Name + ".txt");
            string Conteudo = sr.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            T obj = (T) serializador.Deserialize(Conteudo, typeof(T));

            return obj;
        }

    }
}
