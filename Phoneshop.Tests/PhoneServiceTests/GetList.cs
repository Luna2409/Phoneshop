using Phoneshop.Business;
using Xunit;

namespace Phoneshop.Tests.PhoneServiceTests
{
    public class GetList
    {
        private readonly PhoneService phoneService;

        public GetList()
        {
            phoneService = new PhoneService();
        }

        [Fact]
        public void Should_GiveListOfFivePhones()
        {
            var phones = phoneService.GetList();
            var count = phones.Count;

            Assert.Equal(9, count);
        }
    }
}
