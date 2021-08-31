using System.Collections.Generic;
using System.Threading.Tasks;
using Gaspra.DataPipe.Extract.Models;
using Gaspra.DataPipe.Load.Models;

namespace Gaspra.DataPipe.Transform.Services
{
    public interface ITransformService<in TExtract, TDomain>
        where TDomain : class, IDomain<IFact>
        where TExtract : class, IExtract
    {
        Task<IReadOnlyCollection<TDomain>> TransformExtract(IReadOnlyCollection<TExtract> extracts);
    }
}
