using Phoneshop.Business;
using Phoneshop.Domain.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Xml;

namespace ImportTool.ConsoleApp
{
    public class Program
    {
        private readonly static ImportService importService = new();
        private readonly static PhoneService phoneService = new();
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=phoneshop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        static void Main(string[] args)
        {
            //Console.WriteLine(ConvertXmlToString(args[0]));
            //var xmlString = ConvertXmlToString(args[0]);
            //AddNewPhonesToDatabase(xmlString);

            AddNewPhonesToDatabase(args[0]);
        }

        private static string ConvertXmlToString(string path)
        {
            XmlDocument xmlDoc = new();
            xmlDoc.Load(path);

            return xmlDoc.OuterXml;
        }

        private static void AddNewPhonesToDatabase(string path)
        {
            List<Phone> list = importService.ConvertXmlToList(path);
            List<Phone> phoneList = phoneService.GetList();
            List<Brand> brandList = phoneService.GetBrandList();

            phoneList = phoneList.OrderBy(x => x.Id).ToList();
            var newPhoneId = phoneList[phoneList.Count - 1].Id;
            var newBrandId = brandList[brandList.Count - 1].BrandID;

            foreach (var item in phoneList)
            {
                var hasMatch = list.Any(x => x.FullName == item.FullName);

                if (hasMatch)
                {
                    list.Remove(list.Find(x => x.FullName == item.FullName));
                }
            }

            foreach (var item in list)
            {
                var hasBrand = brandList.Any(x => x.BrandName == item.Brand);

                if (hasBrand)
                {
                    var brandItem = brandList.Find(x => x.BrandName == item.Brand);

                    using (SqlConnection connection = new(connectionString))
                    {
                        var query = "INSERT INTO phones (Id, BrandID, Type, Description, PriceWithTax, Stock) " +
                                    "VALUES (@Id, @Brand, @Type, @Description, @PriceWithTax, @Stock)";

                        using (SqlCommand cmd = new(query, connection))
                        {
                            newPhoneId++;

                            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = newPhoneId;
                            cmd.Parameters.Add("@Brand", SqlDbType.Int).Value = brandItem.BrandID;
                            cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = item.Type;
                            cmd.Parameters.Add("@Description", SqlDbType.VarChar, 3000).Value = item.Description;
                            cmd.Parameters.Add("@PriceWithTax", SqlDbType.Float, 53).Value = item.PriceWithTax;
                            cmd.Parameters.Add("@Stock", SqlDbType.Int).Value = item.Stock;

                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                }
                else
                {
                    using (SqlConnection connection = new(connectionString))
                    {
                        var query1 = "INSERT INTO brands (BrandID, Brand) VALUES (@BrandID, @Brand)";

                        using (SqlCommand cmd = new(query1, connection))
                        {
                            newBrandId++;

                            cmd.Parameters.Add("@BrandID", SqlDbType.Int).Value = newBrandId;
                            cmd.Parameters.Add("@Brand", SqlDbType.NVarChar, 50).Value = item.Brand;

                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }

                        List<Brand> newBrandList = phoneService.GetBrandList();

                        var query2 = "INSERT INTO phones (Id, BrandID, Type, Description, PriceWithTax, Stock) " +
                                     "VALUES (@Id, @Brand, @Type, @Description, @PriceWithTax, @Stock)";
                        var brandItem = newBrandList.Find(x => x.BrandName == item.Brand);

                        using (SqlCommand cmd = new(query2, connection))
                        {
                            newPhoneId++;

                            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = newPhoneId;
                            cmd.Parameters.Add("@Brand", SqlDbType.Int).Value = brandItem.BrandID;
                            cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = item.Type;
                            cmd.Parameters.Add("@Description", SqlDbType.VarChar, 3000).Value = item.Description;
                            cmd.Parameters.Add("@PriceWithTax", SqlDbType.Float, 53).Value = item.PriceWithTax;
                            cmd.Parameters.Add("@Stock", SqlDbType.Int).Value = item.Stock;

                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                }
            }
        }
    }
}
