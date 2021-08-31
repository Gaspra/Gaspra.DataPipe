using System.Collections.Generic;

namespace Gaspra.DataPipe.Load.Models
{
    public interface IDomain<out TFact> where TFact : class, IFact
    {
        TFact Fact { get; }
        IReadOnlyCollection<IDimension<IFact>> Dimensions { get; }
    }
}
