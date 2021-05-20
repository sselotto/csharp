using System;
using System.IO;
using System.Collections.Generic;

namespace Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {   
            string path = @"c:\temp\myfolder";

            try
            {   //Vamos listar as pastas a partir de uma pasta informada 
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                //Vamos listar os arquivos a partir de uma pasta informada
                var files = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files) //Nome da Coleção Files
                {
                    Console.WriteLine(s);
                }

                //Vamos criar uma pasta
                Directory.CreateDirectory(path + "\\newfolder");

            }

            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
