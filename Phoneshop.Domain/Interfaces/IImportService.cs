using Phoneshop.Domain.Objects;
using System.Collections.Generic;

namespace Phoneshop.Domain.Interfaces
{
    public interface IImportService
    {
        List<Phone> ConvertXmlToList(string path);
    }
}
