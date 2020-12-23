using System;

namespace SalesTaxInfra
{
    public class TaxRateProviderException : Exception
    {
        public TaxRateProviderException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
