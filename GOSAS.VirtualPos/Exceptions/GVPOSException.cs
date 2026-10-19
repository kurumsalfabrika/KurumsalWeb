using System;
using System.Runtime.Serialization;

namespace GOSAS.VirtualPos.Core
{
#pragma warning disable S101 // Types should be named in PascalCase

    [Serializable]
    public class GVPOSException : Exception
    {
        public GVPOSException()
        {
        }

        public GVPOSException(string message) : base(message)
        {
        }

        public GVPOSException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GVPOSException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
