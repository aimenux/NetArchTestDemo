using Domain.Models;

namespace Application.Abstractions;

public interface IProductRepository
{
    IEnumerable<Product> GetProducts();
}