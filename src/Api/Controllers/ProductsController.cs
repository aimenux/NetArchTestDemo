﻿using Api.Mappers;
using Api.Payloads;
using Application.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductMapper _productMapper;
    private readonly IProductService _productService;

    public ProductsController(IProductMapper productMapper, IProductService productRepository)
    {
        _productMapper = productMapper;
        _productService = productRepository;
    }

    [HttpGet]
    public IEnumerable<ProductDto> GetProducts()
    {
        return _productService.GetProducts().Select(x => _productMapper.Map(x));
    }
}