using Phoneshop.Domain.Objects;
using System.Collections.Generic;

namespace Phoneshop.Domain.Interfaces
{
    public interface IBrandService
    {
        /// <summary>
        /// Gets a list of all the brands
        /// </summary>
        /// <returns></returns>
        IEnumerable<Brand> GetBrandList();
    }
}
