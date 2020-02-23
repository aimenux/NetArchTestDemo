using System.Collections.Generic;
using Domain.Models;
using Domain.Ports;

namespace Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }
    }
}
