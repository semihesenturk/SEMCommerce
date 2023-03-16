using SEMCommerce.Application.Abstractions;
using SEMCommerce.Domain.Entities;

namespace SEMCommerce.Persistence.Concretes;

public class ProductService : IProductService
{
    public List<Product> GetProducts()
        => new()
        {
            new Product
            {
               Id = Guid.NewGuid(),
               Name = "Product 1",
               Price = 100,
               Stock = 10
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Product 2",
                Price = 50,
                Stock = 2
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Product 3",
                Price = 150,
                Stock = 29
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Product 4",
                Price = 750,
                Stock = 211
            },
        };
}