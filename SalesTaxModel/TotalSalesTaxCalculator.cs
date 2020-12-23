using System.Collections.Generic;
using System.Linq;
using SalesTaxModel.Entities;


namespace SalesTaxModel
{
    public class TotalSalesTaxCalculator : SalesTaxCalculator
    {
        private readonly IEnumerable<SalesTaxCalculator> _taxCalculators;

        public TotalSalesTaxCalculator(IEnumerable<SalesTaxCalculator> taxCalculators)
        {
            _taxCalculators = taxCalculators;
        }

        public override decimal GetTaxAmount(ShoppingCartItem product)
        {
            return _taxCalculators.Sum(x => x.GetTaxAmount(product));
        }
    }
}
