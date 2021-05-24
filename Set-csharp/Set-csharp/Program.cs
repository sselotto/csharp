using System;
using System.Collections.Generic;
using Set_csharp.Entities;
using System.IO;

namespace Set_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>(); //Captura o nome do arquivo

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using(StreamReader sr = File.OpenText(path)) //Vai abrir o arquivo
                {
                    while (!sr.EndOfStream) //Enquanto não chegar no fim do arquivo
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Instant = instant }); 
                    }

                    Console.WriteLine("Total users: " + set.Count);//Quantidade de elementos do conjunto
                }
            }

            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
