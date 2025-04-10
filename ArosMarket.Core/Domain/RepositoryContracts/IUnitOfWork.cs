using ArosMarket.Core.Domain.Entites;
using ArosMarket.Core.Domain.RepositoryContracts.BaseContracts;

namespace ArosMarket.Core.Domain.RepositoryContracts;

internal interface IUnitOfWork : IDisposable
{
    IBaseRepository<User> UserRepository { get; }
    IBaseRepository<Product> ProductRepository { get; }
    IBaseRepository<Content> ContentRepository { get; }
    IBaseRepository<ContentType> ContentTypeRepository { get; }
    IBaseRepository<ProductType> ProductTypeRepository { get; }
    IBaseRepository<Currency> CurrencyRepository { get; }
    IBaseRepository<Gender> GenderRepository { get; }
    IBaseRepository<Role> RoleRepository { get; }
    IBaseRepository<UserStatus> UserStatusRepository { get; }
    IBaseRepository<ProductStatus> ProductStatusRepository { get; }
    IBaseRepository<Order> OrderRepository { get; }
    IBaseRepository<OrderItem> OrderItemRepository { get; }
    IBaseRepository<Payment> PaymentRepostory { get; }
    IBaseRepository<PaymentMethod> PaymentMethodRepository { get; }
    IBaseRepository<PaymentStatus> PaymentStatusRepository { get; }

    Task<int> CompleteAsync();
}
