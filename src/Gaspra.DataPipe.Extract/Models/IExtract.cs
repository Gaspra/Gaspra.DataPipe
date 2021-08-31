using System.Collections.Generic;

namespace Gaspra.DataPipe.Extract.Models
{
    public interface IExtract
    {
        IDictionary<string, IList<IExtractData>> ExtractData { get; set; }
    }

    public interface IExtractData
    {
        (string Key, bool Collection) Metadata { get; }
    }
}
