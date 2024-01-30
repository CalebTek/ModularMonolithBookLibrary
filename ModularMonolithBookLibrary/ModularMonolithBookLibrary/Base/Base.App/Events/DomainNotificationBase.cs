using Base.Domain;


namespace Base.App.Events
{
    public class DomainNotificationBase<T> : IDomainEventNotification<T>
        where T : IDomainEvent
    {
        public T DomainEvent { get; }

        public Guid Id { get; }

        public DomainNotificationBase(T domainEvent, Guid id)
        {
            this.Id = id;
            this.DomainEvent = domainEvent;
        }
    }
}
