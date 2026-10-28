using System.Net;

namespace Support.Domain;

public class SupportTicket
{
    public Guid Id {get;}
    public string Title {get;}
    public TicketStatus Status {get; private set;}
    public SupportTicket(string title)
    {
        if(string.IsNullOrWhiteSpace(title))
        throw new ArgumentException(
            "Заголовок заявки не может быть пустым",
        nameof(title));
        Id = Guid.NewGuid();
        Title = title;
        Status = TicketStatus.New;
    }
    public void ChangeStatus(TicketStatus newStatus)
    {
        bool isAllowed = 
        (Status == TicketStatus.New && 
        newStatus == TicketStatus.InProgress)
        ||
        (Status == TicketStatus.InProgress && 
        newStatus == TicketStatus.Closed);
        
        if (!isAllowed)
        throw new InvalidOperationException(
            $"Нельзя изменить статус с {Status} на {newStatus}.");
        Status = newStatus;
    }
}