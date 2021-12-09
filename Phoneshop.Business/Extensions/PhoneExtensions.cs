using Phoneshop.Domain.Objects;
using System;
using System.Data;

namespace Phoneshop.Business.Extensions
{
    public static class PhoneExtensions
    {
        public static double PriceWithoutVat(this Phone value)
        {
            double priceWithoutTax = value.PriceWithTax / 1.21;

            return Math.Round(priceWithoutTax, 2);
        }

        public static int GetInt(this DataRow dataRow, string columnName)
        {
            return Convert.ToInt32(dataRow[columnName]);
        }

        public static string GetString(this DataRow dataRow, string columnName)
        {
            return Convert.ToString(dataRow[columnName]);
        }

        public static double GetDouble(this DataRow dataRow, string columnName)
        {
            return Convert.ToDouble(dataRow[columnName]);
        }
    }
}
