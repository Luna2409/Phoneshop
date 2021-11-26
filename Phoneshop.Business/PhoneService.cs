using Phoneshop.Domain.Interfaces;
using Phoneshop.Domain.Objects;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace Phoneshop.Business
{
    public class PhoneService : IPhoneService
    {
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=phoneshop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Phone Get(int id)
        {
            var phoneList = GetList().ToList();
            var foundId = phoneList[id - 1].Id;

            var foundPhone = phoneList.FirstOrDefault(x => x.Id == foundId);

            return foundPhone;

            //return GetPhones("SELECT * FROM phones WHERE Id = {id}");
        }

        public List<Phone> GetList()
        {
            return GetPhones().OrderBy(x => x.Brand).ToList();

            //return GetPhones("SELECT * FROM phones ORDER BY Brand");
        }


        public List<Phone> Search(string query)
        {
            return GetPhones().Where(x => x.Brand.ToUpper().Contains(query.ToUpper()) || x.Type.ToUpper().Contains(query.ToUpper()) || x.Description.ToUpper().Contains(query.ToUpper())).OrderBy(x => x.Brand).ToList();

            //return GetPhones("SELECT * FROM phones ORDER BY Brand WHERE Brand LIKE '%{query}%' OR Type LIKE '%{query}%' OR Description LIKE '%{query}%'");
        }


        private IEnumerable<Phone> GetPhones()
        {
            List<Phone> list = new();

            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand cmd = new("SELECT * FROM phones", connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Phone phone = new();
                    phone.Id = reader.GetInt32(0);
                    phone.Brand = reader.GetString(1);
                    phone.Type = reader.GetString(2);
                    phone.Description = reader.GetString(3);
                    phone.PriceWithTax = reader.GetDouble(4);
                    phone.Stock = reader.GetInt32(5);

                    list.Add(phone);
                }
                reader.Close();
            }

            return list;
        }
    }
}
