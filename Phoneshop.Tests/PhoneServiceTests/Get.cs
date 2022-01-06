using Phoneshop.Business;
using Xunit;

namespace Phoneshop.Tests.PhoneServiceTests
{
    public class Get
    {
        private readonly PhoneService phoneService;
        private readonly BrandService brandService;

        public Get()
        {
            phoneService = new PhoneService(brandService);
        }

        [Theory]
        [InlineData(1, "Huawei")]
        [InlineData(2, "Samsung")]
        [InlineData(3, "Apple")]
        [InlineData(4, "Google")]
        [InlineData(5, "Xiaomi")]
        public void Should_GetPhoneById(int id, string brand)
        {
            var phone = phoneService.Get(id);
            Assert.Equal(brand, phone.Brand);
        }

        [Fact]
        public void Should_Return_Null()
        {
            var phone = phoneService.Get(50);

            Assert.Null(phone);

            //Assert.Throws<ArgumentNullException>(() => phoneService.Get(50));
        }
    }
}
