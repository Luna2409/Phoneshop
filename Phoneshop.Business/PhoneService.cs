using Phoneshop.Domain.Interfaces;
using Phoneshop.Domain.Objects;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Phoneshop.Business
{
    public class PhoneService : IPhoneService
    {
        private readonly List<Phone> phones = new()
        {
            new Phone()
            {
                Id = 1,
                Brand = "Huawei",
                Type = "P30",
                PriceWithTax = 697,
                Stock = 50,
                Description = "6.47\" FHD+ (2340x1080) OLED,"
                + Environment.NewLine + "Kirin 980 Octa - Core(2x Cortex - A76 2.6GHz + 2x Cortex - A76 1.92GHz + 4x Cortex - A55 1.8GHz),"
                + Environment.NewLine + "8GB RAM, 128GB ROM, 40 + 20 + 8 + TOF / 32MP,"
                + Environment.NewLine + "Dual SIM, 4200mAh, Android 9.0 + EMUI 9.1"
            },
            new Phone()
            {
                Id = 2,
                Brand = "Samsung",
                Type = "Galaxy A52",
                PriceWithTax = 399,
                Stock = 59,
                Description = "64 megapixel camera, 4k videokwaliteit"
                + Environment.NewLine + "6.5 inch AMOLED scherm"
                + Environment.NewLine + "128 GB opslaggeheugen (Uitbreidbaar met Micro-sd)"
                + Environment.NewLine + "Water- en stofbestendig (IP67)"
            },
            new Phone()
            {
                Id = 3,
                Brand = "Apple",
                Type = "IPhone 11",
                PriceWithTax = 619,
                Stock = 48,
                Description = "Met de dubbele camera schiet je in elke situatie een perfecte foto of video"
                + Environment.NewLine + "De krachtige A13-chipset zorgt voor razendsnelle prestaties"
                + Environment.NewLine + "Met Face ID hoef je enkel en alleen naar je toestel te kijken om te ontgrendelen"
                + Environment.NewLine + "Het toestel heeft een lange accuduur dankzij een energiezuinige processor"
            },
            new Phone()
            {
                Id = 4,
                Brand = "Google",
                Type = "Pixel 4a",
                PriceWithTax = 411,
                Stock = 78,
                Description = "12.2 megapixel camera, 4k videokwaliteit"
                + Environment.NewLine + "5.81 inch OLED scherm"
                + Environment.NewLine + "128 GB opslaggeheugen"
                + Environment.NewLine + "3140 mAh accucapaciteit"
            },
            new Phone()
            {
                Id = 5,
                Brand = "Xiaomi",
                Type = "Redmi Note 10 Pro",
                PriceWithTax = 298,
                Stock = 98,
                Description = "108 megapixel camera, 4k videokwaliteit"
                + Environment.NewLine + "6.67 inch AMOLED scherm"
                + Environment.NewLine + "128 GB opslaggeheugen (Uitbreidbaar met Micro-sd)"
                + Environment.NewLine + "Water- en stofbestendig (IP53)"
            }
        };

        //DataContext dc = new DataContext(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=phoneshop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Phone Get(int id)
        {
            var phoneList = GetList();
            var foundId = phoneList[id - 1].Id;

            var foundPhone = phoneList.FirstOrDefault(x => x.Id == foundId);

            return foundPhone;
        }

        public List<Phone> GetList()
        {
            return phones.OrderBy(x => x.Brand).ToList();
            //SELECT * FROM phones;

            //var phoneList = (Select )
        }


        public List<Phone> Search(string query)
        {
            return phones.Where(x => x.Brand.ToUpper().Contains(query.ToUpper()) || x.Type.ToUpper().Contains(query.ToUpper()) || x.Description.ToUpper().Contains(query.ToUpper())).OrderBy(x => x.Brand).ToList();
        }
    }
}
