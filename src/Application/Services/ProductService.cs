using Application.Abstractions;
using Domain.Models;

namespace Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
    }

    public IEnumerable<Product> GetProducts()
    {
        return _productRepository.GetProducts();
    }
}