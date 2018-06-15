namespace gestalt_asset_core
{
    public class ResourceUrn
    {

        public static readonly string RESOURCE_SEPARATOR = ":";
        public static readonly string FRAGMENT_SEPARATOR = "#";
        public static readonly string INSTANCE_INDICATOR = "!instance";
        private static readonly string URN_PATTERN = @"([^:]+):([^#!]+)(?:#([^!]+))?(!instance)?";

    }
}