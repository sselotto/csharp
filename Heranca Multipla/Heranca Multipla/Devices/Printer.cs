using System;


namespace Heranca_Multipla.Devices
{
    class Printer : Device, IPrinter // A classe Printer vai ser uma sub classe de device e tb vai implementar a classe IPrinter
    {
        public override void ProcessDoc(string document) // Implementacao da Interface Device
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document) // Metodo Print da Interface IPrinter
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
