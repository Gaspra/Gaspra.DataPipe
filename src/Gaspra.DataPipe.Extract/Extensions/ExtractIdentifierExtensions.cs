using System.Collections.Generic;
using System.Linq;
using Gaspra.DataPipe.Extract.Models;

namespace Gaspra.DataPipe.Extract.Extensions
{
    public static class ExtractIdentifierExtensions
    {
        public static bool Match(
            this IExtractIdentifier extractIdentifier,
            IExtractIdentifier comparisonExtractIdentifier)
        {
            if (!extractIdentifier
                .Value
                .Keys
                .Equals(comparisonExtractIdentifier.Value.Keys))
            {
                return false;
            }

            return extractIdentifier
                .Value
                .Keys
                .All(key => extractIdentifier
                    .Value[key]
                    .Equals(comparisonExtractIdentifier.Value[key]));
        }

        public static bool InBatch(
            this IExtractIdentifier extractIdentifier,
            IReadOnlyCollection<IExtractIdentifier> comparisonExtractIdentifiers)
        {
            return comparisonExtractIdentifiers.Any(extractIdentifier.Match);
        }
    }
}
