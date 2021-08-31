using System;
using System.Linq;
using Gaspra.DataPipe.Load.Models;

namespace Gaspra.DataPipe.Load.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class LoadTypeAttribute : Attribute
    {
        public string Name { get; }

        public LoadType? Type { get; } = null;

        public LoadTypeAttribute(Type dataType)
        {
            Name = dataType.FullName;

            var dataTypeInterface = dataType
                .GetInterfaces()
                .First();

            if (typeof(IFact) == dataTypeInterface)
            {
                Type = LoadType.Fact;
            }
            else if (typeof(IDimension<>) == dataTypeInterface)
            {
                Type = LoadType.Dimension;
            }
        }

        public LoadTypeAttribute(string name, LoadType loadType)
        {
            Name = name;
            Type = loadType;
        }
    }
}
