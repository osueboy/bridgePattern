namespace BridgePattern
{
    public interface IDeliveryService
    {
        void PickUp(Package package);
        void Deliver(Package package);
        void Send(Package package);
    }
}
