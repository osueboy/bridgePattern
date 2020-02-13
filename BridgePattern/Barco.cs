using System;

namespace BridgePattern
{
    public class Barco : ITransport
    {
        public void Load(Package package)
        {
            Console.WriteLine("Barco cargado");
        }

        public void Transport(Package package)
        {
            Console.WriteLine("Transportando por barco");
        }

        public void UnLoad(Package package)
        {
            Console.WriteLine("Barco descargado");
        }
    }
}
