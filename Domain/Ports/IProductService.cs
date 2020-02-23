using System.Collections.Generic;
using Domain.Models;

namespace Domain.Ports
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}