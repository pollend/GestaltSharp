using System;

namespace gestalt_module.naming
{
    public class VersionParseException : Exception
    {
        public VersionParseException()
        {    
        }
        
        public VersionParseException(String message):base(message)
        {
        }
    }
}