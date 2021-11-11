using Phoneshop.Business;
using Xunit;

namespace Phoneshop.Tests.VatServiceTests
{
    public class GetPriceWithoutTax
    {
        private readonly VatService taxService;

        public GetPriceWithoutTax()
        {
            taxService = new VatService();
        }

        [Theory]
        [InlineData(697, 576.03)]
        [InlineData(399, 329.75)]
        [InlineData(619, 511.57)]
        [InlineData(411, 339.67)]
        [InlineData(298, 246.28)]
        public void Should_GivePriceWithoutTax(double price, double expected)
        {
            double result = taxService.GetPriceWithoutTax(price);

            Assert.Equal(expected, result);
        }
    }
}
