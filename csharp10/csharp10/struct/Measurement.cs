

namespace csharp10.Struct
{
    internal struct Measurement
    {
        public Measurement()
        {
            Value = double.NaN;
            Description = "Undefined";
        }

        internal Measurement(double value, string description)
        {
            Value = value;
            Description = description;
        }


        public double Value { get; set; }
        public string Description { get; set; }

        public override string ToString() => $"{Value} ({Description})";
    }
}
