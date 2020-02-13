using System;

namespace BridgePattern
{
    public class Estafeta : IDeliveryService
    {
        private ITransport _transport;
        public Estafeta(ITransport transport)
        {
            _transport = transport;
        }
        public void Deliver(Package package)
        {
            Console.WriteLine("Estafeta entregando");
            _transport.Transport(package);
        }

        public void PickUp(Package package)
        {
            Console.WriteLine("Estafeta Recoje");
            _transport.Load(package);
        }

        public void Send(Package package)
        {
            Console.WriteLine("Estafeta Entrega");
            _transport.UnLoad(package);
        }
    }
}
