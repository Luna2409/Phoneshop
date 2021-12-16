using Phoneshop.Domain.Interfaces;
using Phoneshop.Domain.Objects;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Phoneshop.Business
{
    public class BrandService : AdoRepository<Brand>, IBrandService
    {
        public IEnumerable<Brand> GetBrandList()
        {
            return GetList("SELECT * FROM brands");
        }

        public override Brand FillObject(SqlDataReader reader)
        {
            return new Brand
            {
                BrandID = reader.GetInt32(0),
                BrandName = reader.GetString(1),
            };
        }
    }
}
