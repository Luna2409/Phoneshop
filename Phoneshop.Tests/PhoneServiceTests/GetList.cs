using Phoneshop.Business;
using System.Linq;
using Xunit;

namespace Phoneshop.Tests.PhoneServiceTests
{
    public class GetList
    {
        private readonly PhoneService phoneService;
        private readonly BrandService brandService;

        public GetList()
        {
            phoneService = new PhoneService(brandService);
        }

        [Fact]
        public void Should_GiveListOfFivePhones()
        {
            var phones = phoneService.GetList().ToList();
            var count = phones.Count;

            Assert.Equal(9, count);
        }
    }
}
