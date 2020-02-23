using System.Collections.Generic;
using System.Linq;
using Api.Mappers;
using Api.Payloads;
using Domain.Ports;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductMapper _productMapper;
        private readonly IProductService _productService;

        public ProductController(IProductMapper productMapper, IProductService productRepository)
        {
            _productMapper = productMapper;
            _productService = productRepository;
        }

        [HttpGet("all")]
        public IEnumerable<ProductDto> GetProducts()
        {
            return _productService.GetProducts().Select(x => _productMapper.Map(x));
        }
    }
}
