namespace Phoneshop.Domain.Interfaces
{
    public interface IVatService
    {
        /// <summary>
        /// Calculates the price of the phone without tax
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        double GetPriceWithoutTax(double price);
    }
}
