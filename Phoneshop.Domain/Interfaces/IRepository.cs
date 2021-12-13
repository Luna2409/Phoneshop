using Phoneshop.Domain.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoneshop.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T FillObject(SqlDataReader reader);
        void CreatePhone(SqlCommand command, Phone phone);
        //void DeletePhone(SqlCommand command, int id);
        IEnumerable<T> GetBrands(SqlCommand command);
        T GetPhone(int id);
        IEnumerable<T> GetPhones(SqlCommand command);
        void ExecuteNonQuery(SqlCommand command);
    }
}
