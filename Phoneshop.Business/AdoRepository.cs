using Phoneshop.Domain.Interfaces;
using Phoneshop.Domain.Objects;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Phoneshop.Business
{
    public class AdoRepository<T> : IRepository<T> where T : class
    {
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=phoneshop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public virtual T FillObject(SqlDataReader reader) { return null; }

        public void CreateBrand(Phone phone, string query)
        {
            using (SqlConnection connection = new(connectionString))
            {
                using (SqlCommand command = new(query, connection))
                {
                    command.Parameters.Add("@Brand", SqlDbType.NVarChar, 50).Value = phone.Brand;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void CreatePhone(Phone phone, Brand brandItem, string query)
        {
            using (SqlConnection connection = new(connectionString))
            {
                using (SqlCommand command = new(query, connection))
                {
                    command.Parameters.Add("@Brand", SqlDbType.Int).Value = brandItem.BrandID;
                    command.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = phone.Type;
                    command.Parameters.Add("@Description", SqlDbType.VarChar, 3000).Value = phone.Description;
                    command.Parameters.Add("@PriceWithTax", SqlDbType.Float, 53).Value = phone.PriceWithTax;
                    command.Parameters.Add("@Stock", SqlDbType.Int).Value = phone.Stock;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public T GetPhone(string query)
        {
            T phone = null;

            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand command = new(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    phone = FillObject(reader);
                }
                reader.Close();
            }
            return phone;
        }

        public virtual IEnumerable<T> GetList(string query)
        {
            var list = new List<T>();

            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand command = new(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(FillObject(reader));
                }
                reader.Close();
            }

            return list;
        }

        public void ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand command = new(query, connection);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
