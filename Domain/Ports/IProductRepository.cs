﻿using System.Collections.Generic;
using Domain.Models;

namespace Domain.Ports
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
