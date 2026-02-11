namespace CodeTailor.Domain;


public interface IDomainEvent : INotification
{
    Guid Id { get; }
    DateTimeOffset OccurredAt { get; }
}