using System;
using System.IO;

namespace Working_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt"; //Origem
            string targetPath = @"c:\temp\file2.txt"; //Destino

            try // Tudo que for mexer com arquivo vai ficar codificado dentro do bloco try
            {
                FileInfo fileInfo = new FileInfo(sourcePath); // Instaciar um objeto fileInfo que estara associado ao sourcePath
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath); //Faz a varredura de todas as linhas 
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }

            catch (IOException e) // Se tiver algum erro vai ser capturado pelo bloco catch
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message); // Objeto e (excecao)
            }
        }
    }
}
