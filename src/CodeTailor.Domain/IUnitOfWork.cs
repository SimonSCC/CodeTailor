namespace CodeTailor.Domain;

public interface IUnitOfWork
{
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
    void DetachEntity<T>(T entity) where T : class;
}