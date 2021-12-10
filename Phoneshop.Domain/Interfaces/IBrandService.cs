using Phoneshop.Domain.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
