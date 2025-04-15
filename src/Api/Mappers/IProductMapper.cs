using Api.Payloads;
using Domain.Models;

namespace Api.Mappers;

public interface IProductMapper
{
    ProductDto Map(Product product);
}