namespace NLayer.Core.UnitOfWorks;

public interface IUnitOfWork
{
    Task CommitAsync(CancellationToken cancellationToken = default);

    void Commit();
}
