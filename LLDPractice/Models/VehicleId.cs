using System;
using System.Text.RegularExpressions;

namespace LLDPractice.Models
{
    public sealed class VehicleId : IEquatable<VehicleId>
    {
        public Guid Value { get; }

        private VehicleId(Guid value)
        {
            Value = value;
        }

        public static VehicleId Create()
        {
            return new VehicleId(Guid.NewGuid());
        }

        public bool Equals(VehicleId other)
        {
            if (other is null) return false;
            return Value.Equals(other.Value);
        }

        public override bool Equals(object obj)
            => Equals(obj as VehicleId);

        public override int GetHashCode()
            => Value.GetHashCode();

        public override string ToString()
        {
            return Value.ToString();
        }
    }

}
