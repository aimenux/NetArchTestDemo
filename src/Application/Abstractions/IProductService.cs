using Domain.Models;

namespace Application.Abstractions;

public interface IProductService
{
    IEnumerable<Product> GetProducts();
}