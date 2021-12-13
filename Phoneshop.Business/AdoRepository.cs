using Phoneshop.Business.Extensions;
using Phoneshop.Domain.Interfaces;
using Phoneshop.Domain.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Phoneshop.Business
{
    public class AdoRepository<T> : IRepository<T> where T : class
    {
        private readonly SqlConnection _connection;
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=phoneshop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public AdoRepository()
        {
            _connection = new SqlConnection(connectionString);
        }

        public virtual T FillObject(SqlDataReader reader) { return null; }

        public void CreateBrand(Phone phone, int newBrandId, string query)
        {
            using (SqlConnection connection = new(connectionString))
            {
                using (SqlCommand command = new(query, connection))
                {
                    newBrandId++;

                    command.Parameters.Add("@BrandID", SqlDbType.Int).Value = newBrandId;
                    command.Parameters.Add("@Brand", SqlDbType.NVarChar, 50).Value = phone.Brand;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void CreatePhone(Phone phone, int newPhoneId, Brand brandItem, string query)
        {
            using (SqlConnection connection = new(connectionString))
            {
                using (SqlCommand command = new(query, connection))
                {
                    newPhoneId++;

                    command.Parameters.Add("@Id", SqlDbType.Int).Value = newPhoneId;
                    command.Parameters.Add("@Brand", SqlDbType.Int).Value = brandItem.BrandID;
                    command.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = phone.Type;
                    command.Parameters.Add("@Description", SqlDbType.VarChar, 3000).Value = phone.Description;
                    command.Parameters.Add("@PriceWithTax", SqlDbType.Float, 53).Value = phone.PriceWithTax;
                    command.Parameters.Add("@Stock", SqlDbType.Int).Value = phone.Stock;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
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
                connection.Close();
            }
            return phone;

            //var reader = (SqlDataReader)null;
            //T phone = null;

            //command.Connection = _connection;
            //_connection.Open();

            //reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    phone = FillObject(reader);
            //}
            //reader.Close();
            //_connection.Close();
            //_connection.Dispose();

            //return phone;
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
                connection.Close();
            }

            return list;

            //var reader = (SqlDataReader)null;
            //var list = new List<T>();

            //command.Connection = _connection;
            //_connection.Open();

            //reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    list.Add(FillObject(reader));
            //}
            //reader.Close();
            //_connection.Close();
            //_connection.Dispose();

            //return list;
        }

        public void ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand command = new(query, connection);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }


            //command.Connection = _connection;
            //_connection.Open();
            //command.ExecuteNonQuery();
            //_connection.Close();
            //_connection.Dispose();
        }
    }
}
