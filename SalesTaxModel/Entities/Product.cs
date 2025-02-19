﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxModel.Entities
{
    public class Product
    {
        public ProductType Type { get; private set; }
        public string Name { get; private set; }

        public Product(ProductType type, string name)
        {
            Type = type;
            Name = name;
        }
    }
}
