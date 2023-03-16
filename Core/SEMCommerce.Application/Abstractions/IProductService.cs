using SEMCommerce.Domain.Entities;

namespace SEMCommerce.Application.Abstractions;

public interface IProductService
{
    List<Product> GetProducts();
}