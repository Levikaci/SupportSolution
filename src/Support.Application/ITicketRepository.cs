using System;
using System.Threading;
using System.Threading.Tasks;
using Support.Domain;

namespace Support.Application;

public interface ITicketRepository
{
    Task<SupportTicket?> GetAsync(
        Guid id,
        CancellationToken cancellationToken);

    Task SaveAsync(
        SupportTicket ticket,
        CancellationToken cancellationToken);
}
