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
        /// Gets a list of all phones in the shop
        /// </summary>
        /// <returns></returns>
        IEnumerable<Phone> GetList();

        /// <summary>
        /// Searches through the brand, Type and Description for the string
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        IEnumerable<Phone> Search(string query);

        /// <summary>
        /// Deletes a phone
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);

        /// <summary>
        /// Creates a phone
        /// </summary>
        /// <param name="phone"></param>
        void Create(Phone phone);
    }
}
