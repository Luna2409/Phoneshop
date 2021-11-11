using Phoneshop.Domain.Interfaces;
using System;

namespace Phoneshop.Business
{
    public class VatService : IVatService
    {
        //May only be called from ProductService
        public double GetPriceWithoutTax(double price)
        {
            double priceWithoutTax = price / 1.21;

            return Math.Round(priceWithoutTax, 2);
        }
    }
}
