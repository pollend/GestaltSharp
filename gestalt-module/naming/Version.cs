using System;
using System.Text.RegularExpressions;

namespace gestalt_module.naming
{
    public class Version : IEquatable<Name>, IComparable<Name>
    {
        /**
         * A default version of 1.0.0
         */
        public static readonly Version DEFAULT = new Version(1, 0, 0);
        private static readonly Regex VERSION_PATTERN = new Regex(@"(0|[1-9][0-9]*)\\.(0|[1-9][0-9]*)\\.(0|[1-9][0-9]*)(-SNAPSHOT)?");

        
        private int major;
        private int minor;
        private int patch;
        private bool snapshot;

        public Version(int major, int minor, int patch) : this(major, minor, patch, false)
        {
        }

        public Version(int major, int minor, int patch, bool snapshot) {
            if (major < 0 || minor < 0 || patch < 0) {
                throw new ArgumentException("Illegal version " + major + "." + minor + "." + patch + " - all version parts must be positive");
            }
            this.major = major;
            this.minor = minor;
            this.patch = patch;
            this.snapshot = snapshot;
        }
        
        public Version(String version) {
            Match matcher = VERSION_PATTERN.Match(version);
            if (matcher.Success) {
                major = int.Parse(matcher.Groups[1].Value);
                minor = int.Parse(matcher.Groups[2].Value);
                patch = int.Parse(matcher.Groups[3].Value);
                snapshot = !string.IsNullOrEmpty(matcher.Groups[4].Value);
            } else {
                throw new VersionParseException("Invalid version '" + version + "' - must be of the form MAJOR.minor.patch");
            }
        }

        
        public bool Equals(Name other)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public int CompareTo(Name other)
        {
            throw new NotImplementedException();
        }
    }
}