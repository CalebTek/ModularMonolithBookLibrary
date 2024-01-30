namespace Base.Core.DomainEventsDispatching
{
    public interface IDomainEventsDispatcher
    {
        Task DispatchEventsAsync();
    }
}