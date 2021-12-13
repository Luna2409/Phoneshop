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
        private readonly static BrandService brandService = new();

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
            List<Brand> brandList = brandService.GetBrandList().ToList();

            var newPhoneId = phoneList[phoneList.Count - 1].Id;
            var newBrandId = brandList[brandList.Count - 1].BrandID;
            var hasMatch = phoneList.Any(x => x.FullName.ToLower() == phone.FullName.ToLower());

            if (!hasMatch)
            {
                var hasBrand = brandList.Any(x => x.BrandName.ToLower() == phone.Brand.ToLower());

                if (!hasBrand)
                {
                    CreateBrand(phone, newBrandId, "INSERT INTO brands (BrandID, Brand) VALUES (@BrandID, @Brand)");
                }

                List<Brand> newBrandList = brandService.GetBrandList().ToList();
                var brandItem = newBrandList.Find(x => x.BrandName.ToLower() == phone.Brand.ToLower());

                CreatePhone(phone, newPhoneId, brandItem, "INSERT INTO phones (Id, BrandID, Type, Description, PriceWithTax, Stock) VALUES (@Id, @Brand, @Type, @Description, @PriceWithTax, @Stock)");
            }
        }
    }
}
