using System.Collections.Generic;
using System.Threading.Tasks;
using Gaspra.DataPipe.Extract.Models;

namespace Gaspra.DataPipe.Extract.Services
{
    public interface IExtractService<in TExtract> where TExtract : class, IExtract
    {
        Task Extract(IReadOnlyCollection<TExtract> extract);
    }
}
