using System;
using Heranca_Multipla.Devices;

namespace Heranca_Multipla
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Declaração de um objeto do tipo Printer

            Printer p = new Printer() { SerialNumber = 1080 }; // Tem o SerialNumber que foi inicializado

            p.ProcessDoc("My Letter"); //Chama o metodo ProcessDoc
            p.Print("My Letter"); // Chama o metodo Print

            Scanner s = new Scanner() { SerialNumber = 2003 }; // declaração de um objeto do tipo Scanner

            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3021 };

            c.ProcessDoc("My Disssertation");
            c.Print("My Dissertation");

            Console.WriteLine(c.Scan());
            
        }
    }
}
