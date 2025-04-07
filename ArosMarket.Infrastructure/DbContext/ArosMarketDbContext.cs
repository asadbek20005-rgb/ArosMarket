

using ArosMarket.Core.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace ArosMarket.Infrastructure.DbContext;

public class ArosMarketDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public ArosMarketDbContext(Microsoft.EntityFrameworkCore.DbContextOptions<ArosMarketDbContext> options) : base(options)
    {
    }

    public DbSet<Content> Contents { get; set; }

}
