
namespace Base.App.Outbox
{
    public interface IOutbox
    {
        void Add(OutboxMessage message);

        Task Save();
    }
}
