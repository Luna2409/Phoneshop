using Phoneshop.Business.Extensions;
using Phoneshop.Domain.Interfaces;
using Phoneshop.Domain.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

        public void CreatePhone(SqlCommand command, Phone phone)
        {
            throw new NotImplementedException();
        }

        //public void DeletePhone(SqlCommand command, int id)
        //{
        //    throw new NotImplementedException();
        //}

        public virtual IEnumerable<T> GetBrands(SqlCommand command)
        {
            var reader = (SqlDataReader)null;
            var list = new List<T>();

            command.Connection = _connection;
            _connection.Open();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(FillObject(reader));
            }
            reader.Close();
            _connection.Close();
            _connection.Dispose();

            return list;
        }

        public T GetPhone(SqlCommand command)
        {
            var reader = (SqlDataReader)null;
            T phone = null;

            command.Connection = _connection;
            _connection.Open();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                phone = FillObject(reader);
            }
            reader.Close();
            _connection.Close();
            _connection.Dispose();

            return phone;
        }

        public virtual IEnumerable<T> GetPhones(SqlCommand command)
        {
            var reader = (SqlDataReader)null;
            var list = new List<T>();

            command.Connection = _connection;
            _connection.Open();
            
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(FillObject(reader));
            }
            reader.Close();
            _connection.Close();
            _connection.Dispose();

            return list;
        }

        public void ExecuteNonQuery(SqlCommand command)
        {
            command.Connection = _connection;
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
            _connection.Dispose();
        }
    }
}
