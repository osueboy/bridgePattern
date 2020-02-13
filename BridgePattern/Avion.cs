using System;

namespace BridgePattern
{
    public class Avion : ITransport
    {
        public void Load(Package package)
        {
            Console.WriteLine("Avión cargado");
        }

        public void Transport(Package package)
        {
            Console.WriteLine("Transportando por Avión");
        }

        public void UnLoad(Package package)
        {
            Console.WriteLine("Avión descargado");
        }
    }
}
