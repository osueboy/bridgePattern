using System;

namespace BridgePattern
{
    public class Fedex : IDeliveryService
    {
        private ITransport _transport;
        public Fedex(ITransport transport)
        {
            _transport = transport;
        }
        public void Deliver(Package package)
        {
            Console.WriteLine("Fedex entregando");
            _transport.Transport(package);
        }

        public void PickUp(Package package)
        {
            Console.WriteLine("Fedex Recoje");
            _transport.Load(package);
        }

        public void Send(Package package)
        {
            Console.WriteLine("Fedex Entrega");
            _transport.UnLoad(package);
        }
    }
}
