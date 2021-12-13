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
    public class BrandService : AdoRepository<Brand>, IBrandService
    {
        public IEnumerable<Brand> GetBrandList()
        {
            return GetList("SELECT * FROM brands");


            //using (var command = new SqlCommand())
            //{
            //    return GetBrands("SELECT * FROM brands");
            //}
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
