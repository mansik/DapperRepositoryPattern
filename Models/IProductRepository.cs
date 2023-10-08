﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperRepositoryPattern
{
    internal interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        bool Insert(Product product);
        bool Update(Product product);
        bool Delete(string productId);        
    }
}
