namespace Base.App
{
    public interface IExecutionContextAccessor
    {
        Guid UserId { get; }

        Guid CorrelationId { get; }

        bool IsAvailable { get; }
    }
}