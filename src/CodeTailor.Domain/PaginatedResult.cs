namespace CodeTailor.Domain;

public record PaginatedResult<T>(int TotalCount, IReadOnlyCollection<T> Items) where T : Entity;