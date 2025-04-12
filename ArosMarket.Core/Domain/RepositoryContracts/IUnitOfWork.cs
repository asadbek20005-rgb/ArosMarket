using ArosMarket.Core.Domain.Entites;
using ArosMarket.Core.Domain.RepositoryContracts.BaseContracts;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace ArosMarket.Core.Domain.RepositoryContracts;

public interface IUnitOfWork{
    IBaseRepository<Content> ContentRepository { get; }
    IBaseRepository<Product> ProductRepository { get; }
    IBaseRepository<ProductType> ProductTypeRepository { get; }
    IBaseRepository<ProductStatus> ProductStatusRepository { get; }
    Task<int> CompleteAsync();
    Task<IDbContextTransaction> BeginTransactionAsync();
    Task CommitAsync();
    Task RollbackAsync();
}
