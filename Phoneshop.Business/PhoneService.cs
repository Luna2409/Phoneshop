using Phoneshop.Domain.Interfaces;
using Phoneshop.Domain.Objects;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace Phoneshop.Business
{
    public class PhoneService : AdoRepository<Phone>, IPhoneService
    {
        private readonly IBrandService _brandService;

        public PhoneService(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public Phone Get(int id)
        {
            return GetPhone($"SELECT * FROM phones INNER JOIN brands ON phones.BrandID=brands.BrandID WHERE Id = {id}");
        }

        public IEnumerable<Phone> GetList()
        {
            return GetList("SELECT * FROM phones INNER JOIN brands ON phones.BrandID=brands.BrandID ORDER BY Brand");
        }

        public IEnumerable<Phone> Search(string query)
        {
            return GetList($"SELECT * FROM phones INNER JOIN brands ON phones.BrandID=brands.BrandID " +
                $"WHERE Brand LIKE '%{query}%' OR Type LIKE '%{query}%' OR Description LIKE '%{query}%'").OrderBy(x => x.Brand);
        }

        public override Phone FillObject(SqlDataReader reader)
        {
            return new Phone
            {
                Id = reader.GetInt32(0),
                BrandID = reader.GetInt32(1),
                Type = reader.GetString(2),
                Description = reader.GetString(3),
                PriceWithTax = reader.GetDouble(4),
                Stock = reader.GetInt32(5),
                Brand = reader.GetString(7),
            };
        }

        public void Delete(int id)
        {
            ExecuteNonQuery($"DELETE FROM phones WHERE phones.Id = {id}");
        }

        public void Create(Phone phone)
        {
            List<Phone> phoneList = GetList().OrderBy(x => x.Id).ToList();
            List<Brand> brandList = _brandService.GetBrandList().ToList();

            var hasMatch = phoneList.Any(x => x.FullName.ToLower() == phone.FullName.ToLower());

            if (!hasMatch)
            {
                var hasBrand = brandList.Any(x => x.BrandName.ToLower() == phone.Brand.ToLower());

                if (!hasBrand)
                {
                    CreateBrand(phone, "INSERT INTO brands (Brand) VALUES (@Brand)");
                }

                List<Brand> newBrandList = _brandService.GetBrandList().ToList();
                var brandItem = newBrandList.Find(x => x.BrandName.ToLower() == phone.Brand.ToLower());

                CreatePhone(phone, brandItem, "INSERT INTO phones (BrandID, Type, Description, PriceWithTax, Stock) VALUES (@Brand, @Type, @Description, @PriceWithTax, @Stock)");
            }
        }
    }
}