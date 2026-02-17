using System;
using System.Text.RegularExpressions;

namespace LLDPractice.Models
{
    public sealed class VehicleName : IEquatable<VehicleName>
    {
        public string Value { get; }

        private VehicleName(string value)
        {
            Value = value;
        }

        public static VehicleName Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Vehicle name cannot be empty.");

            if (value.Length > 50)
                throw new ArgumentException("Vehicle name cannot exceed 50 characters.");

            if (!Regex.IsMatch(value, "^[a-zA-Z0-9]+$"))
                throw new ArgumentException("Vehicle name must be alphanumeric.");

            return new VehicleName(value);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as VehicleName);
        }

        public bool Equals(VehicleName other)
        {
            if (other is null)
                return false;

            return Value == other.Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value;
        }
    }
}