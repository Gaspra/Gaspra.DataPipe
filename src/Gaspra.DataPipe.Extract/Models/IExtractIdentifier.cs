using System.Collections.Generic;

namespace Gaspra.DataPipe.Extract.Models
{
    public interface IExtractIdentifier
    {
        IDictionary<string, string> Value { get; }
    }
}
