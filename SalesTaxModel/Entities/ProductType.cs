using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxModel.Entities
{
    [Flags]
    public enum ProductType
    {
        Book = 1,
        Food = 2,
        Medical = 4,
        Music = 8,
        Perfume = 16
    }
}
