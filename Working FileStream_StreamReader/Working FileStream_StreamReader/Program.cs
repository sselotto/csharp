using System;
using System.IO;

namespace Working_FileStream_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";

            //Primeiro fazer instanciação os dois obj (filestream associado os arquivos 
            //e depois streamreader associado com filestream)

            FileStream fs = null; //uma stream generica que nao faz nenhum tratamento especial pra acessar um recurso
            StreamReader sr = null; //uma stream particular otimizada

            try // Colocar as instanciações
            {
                fs = new FileStream(path, FileMode.Open); //O recurso nao é gerenciado pelo clr dotnet...vai ter que fechar manualmente
                sr = new StreamReader(fs);
                

                //Criando uma variavel line
                string line = sr.ReadLine();
                Console.WriteLine(line);

            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            //fechar as streams 
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
