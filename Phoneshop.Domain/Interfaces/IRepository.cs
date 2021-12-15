using Phoneshop.Domain.Objects;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Phoneshop.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T FillObject(SqlDataReader reader);
        void CreateBrand(Phone phone, string query);
        void CreatePhone(Phone phone, Brand brandItem, string query);
        T GetPhone(string query);
        IEnumerable<T> GetList(string query);
        void ExecuteNonQuery(string query);
    }
}
