using System;

namespace Gaspra.DataPipe.Load.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class LoadColumnOverrideAttribute : Attribute
    {
        public string Name { get; }

        public LoadColumnOverrideAttribute(string name)
        {
            Name = name;
        }
    }
}
