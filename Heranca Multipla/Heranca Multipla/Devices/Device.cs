
namespace Heranca_Multipla.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; } // Propriedade SerialNumber

        public abstract void ProcessDoc(string document); // Declaração do metodo ProcessDoc


    }
}
