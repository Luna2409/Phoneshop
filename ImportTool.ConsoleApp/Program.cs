using Phoneshop.Business;
using Phoneshop.Domain.Objects;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Xml;

namespace ImportTool.ConsoleApp
{
    public class Program
    {
        private readonly static ImportService importService = new();
        private readonly static PhoneService phoneService = new();
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=phoneshop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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
