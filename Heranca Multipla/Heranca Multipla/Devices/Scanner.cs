using System;

namespace Heranca_Multipla.Devices
{
    class Scanner : Device, IScanner // A classe Scanner vai Herdar Device e implementa a interface IScanner
    {
        public override void ProcessDoc(string document) // Implementacao  Device
        {
            Console.WriteLine("Scanner Processing: " + document); // ter um controle do que esta acontecendo
        }

        public string Scan() // Implementacao da Interface IScanner
        {
            return "Scanner scan result";
        }

    }
}
