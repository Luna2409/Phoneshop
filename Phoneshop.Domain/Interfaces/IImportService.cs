using Phoneshop.Domain.Objects;
using System.Collections.Generic;

namespace Phoneshop.Domain.Interfaces
{
    public interface IImportService
    {
        /// <summary>
        /// Converts a XML file to a list of phones
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        List<Phone> ConvertXmlToList(string path);
    }
}
