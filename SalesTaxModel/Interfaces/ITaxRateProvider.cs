using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxModel.Interfaces
{
    public interface ITaxRateProvider
    {
        decimal GetBasicSalesTaxRate();
        decimal GetImportDutySalesTaxRate();
    }
}
