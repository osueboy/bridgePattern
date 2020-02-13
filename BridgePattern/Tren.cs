using System;

namespace BridgePattern
{
    public class Tren : ITransport
    {
        public void Load(Package package)
        {
            Console.WriteLine("Tren cargado");
        }

        public void Transport(Package package)
        {
            Console.WriteLine("Transportando por tren");
        }

        public void UnLoad(Package package)
        {
            Console.WriteLine("Tren descargado");
        }
    }
}
