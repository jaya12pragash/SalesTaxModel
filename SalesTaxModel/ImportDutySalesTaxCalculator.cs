using SalesTaxModel.Entities;
using SalesTaxModel.Interfaces;

namespace SalesTaxModel
{
    public class ImportDutySalesTaxCalculator : SalesTaxCalculator
    {
        private readonly ITaxRateProvider _taxRateProvider;

        public ImportDutySalesTaxCalculator(ITaxRateProvider taxRateProvider)
        {
            _taxRateProvider = taxRateProvider;
        }

        public override decimal GetTaxAmount(ShoppingCartItem item)
        {
            return item.IsImported ? item.BasePrice * _taxRateProvider.GetImportDutySalesTaxRate() : 0.0m;
        }
    }
}
