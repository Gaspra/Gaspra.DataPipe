using System.Collections.Generic;
using System.Threading.Tasks;
using Gaspra.DataPipe.Load.Models;

namespace Gaspra.DataPipe.Load.Services
{
    public interface ILoadService<in TDomain> where TDomain : class, IDomain<IFact>
    {
        Task MergeDomain(IReadOnlyCollection<TDomain> domain);
    }
}
