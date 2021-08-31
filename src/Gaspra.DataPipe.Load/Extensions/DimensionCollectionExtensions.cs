using System.Collections.Generic;
using Gaspra.DataPipe.Load.Models;

namespace Gaspra.DataPipe.Load.Extensions
{
    public static class DimensionCollectionExtensions
    {
        public static IList<IDimension<IFact>> AddWhenNotNull(
            this IList<IDimension<IFact>> dimensions,
            IDimension<IFact> dimension)
        {
            if (dimension != null)
            {
                dimensions.Add(dimension);
            }

            return dimensions;
        }
    }
}
