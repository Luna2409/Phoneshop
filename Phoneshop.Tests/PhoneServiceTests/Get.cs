using Phoneshop.Business;
using System;
using Xunit;

namespace Phoneshop.Tests.PhoneServiceTests
{
    public class Get
    {
        private readonly PhoneService phoneService;

        public Get()
        {
            phoneService = new PhoneService();
        }

        [Theory]
        [InlineData(2, "Apple")]
        [InlineData(3, "Google")]
        [InlineData(4, "Huawei")]
        [InlineData(5, "Samsung")]
        [InlineData(6, "Xiaomi")]
        public void Should_GetPhoneById(int id, string brand)
        {
            var phone = phoneService.Get(id);
            Assert.Equal(brand, phone.Brand);
        }

        [Fact]
        public void Should_GiveArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => phoneService.Get(7));
        }
    }
}
