using System;
using Support.Domain;
using Xunit;

namespace Support.UnitTests;

public class UnitTest1
{
    [Fact]
    public void ChangeStatus_NewToInProgress_Success()
    {
        var ticket = new SupportTicket("Проверка заявки");

        ticket.ChangeStatus(TicketStatus.InProgress);

        Xunit.Assert.Equal(TicketStatus.InProgress, ticket.Status);
    }

    [Fact]
    public void ChangeStatus_NewToClosed_ThrowsException()
    {
        var ticket = new SupportTicket("Проверка заявки");

        Xunit.Assert.Throws<InvalidOperationException>(
            () => ticket.ChangeStatus(TicketStatus.Closed));
    }
}
