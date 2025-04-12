
using ArosMarket.Core.Domain.Entites;
using ArosMarket.Core.Domain.RepositoryContracts;
using ArosMarket.Core.Domain.RepositoryContracts.BaseContracts;
using ArosMarket.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore.Storage;

namespace ArosMarket.Infrastructure.Repositories;

public class UnitOfWOrk(ArosMarketDbContext arosMarketDbContext) : IUnitOfWork
{
    private readonly ArosMarketDbContext _context = arosMarketDbContext;
    private IBaseRepository<Content>? _contentRepository;
    private IBaseRepository<Product>? _productRepository;
    private IBaseRepository<ProductType>? _productTypeRepository;
    private IBaseRepository<ProductStatus>? _productStatusRepository;
    public IBaseRepository<Content> ContentRepository
    {
        get
        {
            if (_contentRepository is null)
            {
                _contentRepository = new BaseRepository<Content>(_context);
            }
            return _contentRepository;
        }
    }

    public IBaseRepository<Product> ProductRepository
    {
        get
        {
            if (_productRepository is null)
            {
                _productRepository = new BaseRepository<Product>(_context);
            }
            return _productRepository;
        }
    }

    public IBaseRepository<ProductType> ProductTypeRepository
    {
        get
        {
            if (_productTypeRepository is null)
            {
                _productTypeRepository = new BaseRepository<ProductType>(_context);
            }
            return _productTypeRepository;
        }
    }

    public IBaseRepository<ProductStatus> ProductStatusRepository
    {
        get
        {
            if (_productStatusRepository is null)
            {
                _productStatusRepository = new BaseRepository<ProductStatus>(_context);
            }
            return _productStatusRepository;
        }
    }

    public Task<IDbContextTransaction> BeginTransactionAsync()
    {
       return _context.Database.BeginTransactionAsync();
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
