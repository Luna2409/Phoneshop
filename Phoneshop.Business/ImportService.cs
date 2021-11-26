using Phoneshop.Domain.Interfaces;
using Phoneshop.Domain.Objects;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Phoneshop.Business
{
    public class ImportService : IImportService
    {
        public List<Phone> ConvertXmlToList(string path)
        {
            List<Phone> list = new();

            using (var reader = XmlReader.Create(path))
            {
                Phone phone = null;

                while (reader.Read())
                {
                    if ((!reader.IsStartElement()) && reader.Name.ToString() == "Phone")
                        list.Add(phone);

                    if (reader.IsStartElement() && reader.Name.ToString() == "Phone")
                        phone = new Phone();

                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "Brand":
                                if (reader.Read())
                                {
                                    phone.Brand = reader.Value;
                                }
                                break;
                            case "Type":
                                if (reader.Read())
                                {
                                    phone.Type = reader.Value;
                                }
                                break;
                            case "Price":
                                if (reader.Read())
                                {
                                    phone.PriceWithTax = Convert.ToDouble(reader.Value);
                                }
                                break;
                            case "Description":
                                if (reader.Read())
                                {
                                    phone.Description = reader.Value;
                                }
                                break;
                            case "Stock":
                                if (reader.Read())
                                {
                                    phone.Stock = Convert.ToInt32(reader.Value);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    
                }
            }
            return list;
        }
    }
}
