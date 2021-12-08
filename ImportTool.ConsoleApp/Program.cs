using Phoneshop.Business;
using Phoneshop.Domain.Objects;
using System.Collections.Generic;

namespace ImportTool.ConsoleApp
{
    public class Program
    {
        private readonly static ImportService importService = new();
        private readonly static PhoneService phoneService = new();

        static void Main(string[] args)
{
            List<Phone> importList = importService.ConvertXmlToList(args[0]);

            foreach (var item in importList)
            {
                phoneService.Create(item);
            }
        }

    }
}
