using Base.Core.DomainEventsDispatching;
using Microsoft.EntityFrameworkCore;


namespace Base.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private readonly DomainEventsDispatcher _domainEventsDispatcher;

        public UnitOfWork(
            DbContext context,
            IDomainEventsDispatcher domainEventsDispatcher)
        {
            this._context = context;
            this._domainEventsDispatcher = (DomainEventsDispatcher?)domainEventsDispatcher;
        }

        public async Task<int> CommitAsync(
            CancellationToken cancellationToken = default,
            Guid? internalCommandId = null)
        {
            await this._domainEventsDispatcher.DispatchEventsAsync();

            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
