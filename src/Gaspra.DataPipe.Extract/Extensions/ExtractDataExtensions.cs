using System;
using System.Collections.Generic;
using System.Linq;
using Gaspra.DataPipe.Extract.Models;

namespace Gaspra.DataPipe.Extract.Extensions
{
    public static class ExtractDataExtensions
    {
        public static IExtract AddExtractData(this IExtract extract, IExtractData extractData)
        {
            IDictionary<string, IList<IExtractData>> extractDataDictionary;

            if (extract.ExtractData is null || !extract.ExtractData.Any())
            {
                extractDataDictionary = new Dictionary<string, IList<IExtractData>>();
            }
            else
            {
                extractDataDictionary = extract.ExtractData;
            }

            if (!extractData.Metadata.Collection)
            {
                if (extractDataDictionary.ContainsKey(extractData.Metadata.Key))
                {
                    throw new Exception($"Can't add more than one [{extractData.Metadata.Key}]");
                }

                extractDataDictionary.Add(extractData.Metadata.Key, new List<IExtractData> { extractData });
            }
            else
            {
                if (extractDataDictionary.ContainsKey(extractData.Metadata.Key))
                {
                    var extractDataCollection = extractDataDictionary[extractData.Metadata.Key];

                    extractDataCollection.Add(extractData);

                    extractDataDictionary[extractData.Metadata.Key] = extractDataCollection;
                }
                else
                {
                    extractDataDictionary.Add(extractData.Metadata.Key, new List<IExtractData> { extractData });
                }
            }

            extract.ExtractData = extractDataDictionary;

            return extract;
        }

        public static IExtract AddExtractDataCollection(this IExtract extract, IReadOnlyCollection<IExtractData> extractDataCollection)
        {
            return extractDataCollection.Aggregate(extract, (current, extractData) => current.AddExtractData(extractData));
        }
    }
}
