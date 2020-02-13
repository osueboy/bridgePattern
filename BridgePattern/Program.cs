using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransport tren = new Tren();
            ITransport barco = new Barco();
            ITransport avion = new Avion();
            /*
             Crear la empresa fedex que enviara un pedido por mar.
• Crear la empresa DHL que enviara un pedido por aire y otro por barco
• Crear la empresa Estafeta que enviara un pedido por tren
             */
            IDeliveryService fedexMar = new Fedex(barco); 
            IDeliveryService dhlAire = new Dhl(avion);
            IDeliveryService dhlMar = new Dhl(barco);
            IDeliveryService estafetaTren = new Estafeta(tren);


            Console.WriteLine("Servicios de entrega");
            Package package = new Package();

            fedexMar.Deliver(package);
            dhlAire.Deliver(package);
            dhlMar.Deliver(package);
            estafetaTren.Deliver(package);


        }
    }
}
