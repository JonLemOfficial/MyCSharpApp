using System;

namespace MyCSharpApp.Desktop.Components
{
    public class PeoplePropChangedEventArgs : EventArgs
    {
        public string Name { get; private set; }
        public object Value { get; private set; }
        public Type ValueType { get; private set; }

        public PeoplePropChangedEventArgs(string Name, object Value, Type ValueType)
        {
            this.Name = Name;
            this.Value = Value;
            this.ValueType = ValueType;
        }
    }
}
