using ArosMarket.Core.Domain.RepositoryContracts.BaseContracts;

namespace ArosMarket.Core.Domain.RepositoryContracts;

public interface IUnitOfWork<TEntity> where TEntity : class, IDisposable
{
    IBaseRepository<TEntity> Repository { get; }
    Task<int> CompleteAsync();
    Task BeginTransactionAsync();
    Task CommitAsync();
    Task RollbackAsync();
}
