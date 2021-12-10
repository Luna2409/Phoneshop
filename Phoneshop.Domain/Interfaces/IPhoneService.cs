using Phoneshop.Domain.Objects;
using System.Collections.Generic;

namespace Phoneshop.Domain.Interfaces
{
    public interface IPhoneService
    {
        /// <summary>
        /// Get Details of a phone by the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Phone Get(int id);

        /// <summary>
        /// Get a list of all phones in the shop
        /// </summary>
        /// <returns></returns>
        IEnumerable<Phone> GetList();

        IEnumerable<Phone> Search(string query);

        IEnumerable<Brand> GetBrandList();

        void Delete(int id);

        void Create(Phone phone);
    }
}
