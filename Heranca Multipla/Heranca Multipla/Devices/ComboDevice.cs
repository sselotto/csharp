using Heranca_Multipla.Devices;
using System;

namespace Heranca_Multipla.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice Processing " + document);
        }

        public string Scan()
        {
            return "Combodevice scan result";
        }
    }
}
