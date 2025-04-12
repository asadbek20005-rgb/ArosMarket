

using ArosMarket.Core.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace ArosMarket.Infrastructure.DbContext;

public class ArosMarketDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public ArosMarketDbContext(Microsoft.EntityFrameworkCore.DbContextOptions<ArosMarketDbContext> options) : base(options)
    {
    }

    public DbSet<Content> Contents { get; set; }
    public DbSet<Product> Products { get; set; }

    public DbSet<ProductType> ProductTypes { get; set; }
    public DbSet<ProductStatus> ProductStatuses { get; set; }


}
