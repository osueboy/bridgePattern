namespace BridgePattern
{
    public interface ITransport
    {
        void Load(Package package);
        void Transport(Package package);
        void UnLoad(Package package);
    }
}
