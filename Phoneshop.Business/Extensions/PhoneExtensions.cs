using Phoneshop.Domain.Objects;
using System;

namespace Phoneshop.Business.Extensions
{
    public static class PhoneExtensions
    {
        public static double PriceWithoutVat(this Phone value)
        {
            double priceWithoutTax = value.PriceWithTax / 1.21;

            return Math.Round(priceWithoutTax, 2);
        }
    }
}
