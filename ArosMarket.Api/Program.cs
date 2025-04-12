using ArosMarket.Core.Domain.Entites;
using ArosMarket.Core.Domain.RepositoryContracts;
using ArosMarket.Core.Domain.RepositoryContracts.BaseContracts;
using ArosMarket.Core.Models.ProductModels;
using ArosMarket.Core.ServiceContracts;
using ArosMarket.Core.Services;
using ArosMarket.Core.Validators;
using ArosMarket.Infrastructure.DbContext;
using ArosMarket.Infrastructure.Repositories;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ArosMarketDbContext>(options =>
    options.UseNpgsql(connectionString));
builder.Services.AddScoped<IUnitOfWork, UnitOfWOrk>();
builder.Services.AddScoped<IBaseRepository<Product>, BaseRepository<Product>>();
builder.Services.AddScoped<IBaseRepository<ProductType>, BaseRepository<ProductType>>();
builder.Services.AddScoped<IBaseRepository<ProductStatus>, BaseRepository<ProductStatus>>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IValidator<AddProductModel>, AddProductModelValidator>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
