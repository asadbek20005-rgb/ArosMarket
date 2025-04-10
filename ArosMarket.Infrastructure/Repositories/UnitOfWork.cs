
using ArosMarket.Core.Domain.RepositoryContracts;
using ArosMarket.Core.Domain.RepositoryContracts.BaseContracts;
using ArosMarket.Infrastructure.DbContext;

namespace ArosMarket.Infrastructure.Repositories;

public class UnitOfWOrk<TEntity>(ArosMarketDbContext arosMarketDbContext) : IUnitOfWork<TEntity> where TEntity : class, IDisposable
{
    private readonly ArosMarketDbContext _context = arosMarketDbContext;
    private IBaseRepository<TEntity>? _repository;
    public IBaseRepository<TEntity> Repository
    {
        get
        {
            if (_repository == null)
            {
                _repository = new BaseRepository<TEntity>(_context);
            }
            return _repository;
        }
    }

    public async Task BeginTransactionAsync()
    {
        await _context.Database.BeginTransactionAsync();
    }

    public async Task CommitAsync()
    {
        await _context.Database.CommitTransactionAsync();
    }

    public async Task<int> CompleteAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public async Task RollbackAsync()
    {
        await _context.Database.RollbackTransactionAsync();
    }
}
