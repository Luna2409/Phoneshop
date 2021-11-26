using Phoneshop.Business;
using Phoneshop.Domain.Objects;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ImportTool.ConsoleApp
{
    public class Program
    {
        private readonly static ImportService importService = new();
        private readonly static PhoneService phoneService = new();
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=phoneshop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        static void Main(string[] args)
        {
            AddNewPhonesToDatabase(args[0]);
        }

        private static void AddNewPhonesToDatabase(string path)
        {
            List<Phone> list = importService.ConvertXmlToList(path);
            List<Phone> phoneList = phoneService.GetList();
            phoneList = phoneList.OrderBy(x => x.Id).ToList();
            var number = phoneList[phoneList.Count - 1].Id;

            foreach (var item in phoneList)
            {
                var hasMatch = list.Any(x => x.FullName == item.FullName);

                if (hasMatch)
                {
                    list.Remove(list.Find(x => x.FullName == item.FullName));
                }
            }

            foreach (var item in list)
            {
                using (SqlConnection connection = new(connectionString))
                {
                    var query = $"INSERT INTO phones (Id, Brand, Type, Description, PriceWithTax, Stock) " +
                                $"VALUES (@Id, @Brand, @Type, @Description, @PriceWithTax, @Stock)";

                    using (SqlCommand cmd = new(query, connection))
                    {
                        number++;

                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = number;
                        cmd.Parameters.Add("@Brand", SqlDbType.NVarChar, 50).Value = item.Brand;
                        cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = item.Type;
                        cmd.Parameters.Add("@Description", SqlDbType.VarChar, 3000).Value = item.Description;
                        cmd.Parameters.Add("@PriceWithTax", SqlDbType.Float, 53).Value = item.PriceWithTax;
                        cmd.Parameters.Add("@Stock", SqlDbType.Int).Value = item.Stock;

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                    }
                }
            }

        }
    }
}
