using ArosMarket.Core.Domain.RepositoryContracts.BaseContracts;
using ArosMarket.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;

namespace ArosMarket.Infrastructure.Repositories;

public class BaseRepository<TEntity>(ArosMarketDbContext context)
    : IBaseRepository<TEntity>
    where TEntity : class
{
    private readonly ArosMarketDbContext _context = context;

    public async Task AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
    }

    public void Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _context.Set<TEntity>()
            .ToListAsync();
    }

    public async Task<TEntity?> GetByIdAsync<TId>(TId id)
    {
        return await _context.Set<TEntity>()
            .FindAsync(id);
    }

    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }

    public void Update(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
    }
}
