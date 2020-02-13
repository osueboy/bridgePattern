using System;

namespace BridgePattern
{
    public class Dhl : IDeliveryService
    {
        private ITransport _transport;
        public Dhl(ITransport transport)
        {
            _transport = transport;
        }
        public void Deliver(Package package)
        {
            Console.WriteLine("Dhl entregando");
            _transport.Transport(package);
        }
        public void PickUp(Package package)
        {
            Console.WriteLine("Dhl Recoje");
            _transport.Load(package);
        }
        public void Send(Package package)
        {
            Console.WriteLine("Dhl Entrega");
            _transport.UnLoad(package);
        }
    }
}
