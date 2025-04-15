using Application.Abstractions;
using Domain.Models;

namespace Infrastructure;

public class ProductRepository : IProductRepository
{
    public IEnumerable<Product> GetProducts()
    {
        return
        [
            new Product
            {
                Id = 1,
                Name = "Apple",
                Price = 2.5m
            },
            new Product
            {
                Id = 2,
                Name = "Orange",
                Price = 3.5m
            },
            new Product
            {
                Id = 3,
                Name = "Banana",
                Price = 1.5m
            }
        ];
    }
}