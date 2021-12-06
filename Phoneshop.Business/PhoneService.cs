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
            var phoneList = GetList().OrderBy(x => x.Id).ToList();
            var foundPhone = phoneList.FirstOrDefault(x => x.Id == id);

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

        public List<Brand> GetBrandList()
        {
            List<Brand> brandList = new();

            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand cmd = new("SELECT * FROM brands", connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                { 
                    Brand brand = new();
                    brand.BrandID = reader.GetInt32(0);
                    brand.BrandName = reader.GetString(1);

                    brandList.Add(brand);
                }
                reader.Close();
                connection.Close();
            }
            return brandList;
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand cmd = new($"DELETE FROM phones WHERE phones.Id = {id}", connection);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private IEnumerable<Phone> GetPhones()
        {
            List<Phone> list = new();

            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand cmd = new("SELECT phones.Id, brands.Brand, phones.Type, phones.Description, phones.PriceWithTax, phones.Stock " +
                                     "FROM phones " +
                                     "INNER JOIN brands " +
                                     "ON phones.BrandID=brands.BrandID", connection);

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
                connection.Close();
            }

            return list;
        }
    }
}
