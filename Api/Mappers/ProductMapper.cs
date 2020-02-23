using Api.Payloads;
using Domain.Models;

namespace Api.Mappers
{
    public class ProductMapper : IProductMapper
    {
        public ProductDto Map(Product product)
        {
            if (product == null)
            {
                return null;
            }

            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }
    }
}