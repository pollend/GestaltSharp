using System;
using System.Diagnostics;

namespace gestalt_module.naming
{
    public class Name : IEquatable<Name>, IComparable<Name>
    {
        public static readonly Name EMPTY = new Name("");

        private readonly string orignalName;
        private readonly string normalisedName;

        public Name(String name)
        {
            Debug.Assert(name != null);
            orignalName = name;
            normalisedName = name.ToLower();
        }

        public bool IsEmpty()
        {
            return String.IsNullOrEmpty(normalisedName);
        }

        public string ToLowerCase()
        {
            return this.normalisedName;
        }

        public String ToUpperCase()
        {
            return orignalName.ToUpper();
        }
        
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Name) obj);
        }

        public bool Equals(Name other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return normalisedName.Equals(other.normalisedName);
        }

        public override int GetHashCode()
        {
            return normalisedName.GetHashCode();
        }

        public override string ToString()
        {
            return orignalName;
        }

        public int CompareTo(Name other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return String.CompareOrdinal(normalisedName, other.normalisedName);
        }
    }
}