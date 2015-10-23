using System;
using System.Runtime.Serialization;

namespace AutoescuelaAppCSharp.Classes
{
    [Serializable]
    internal class UserEdadException : Exception
    {
        public UserEdadException()
        {
        }

        public UserEdadException(string message) : base(message)
        {
        }

        public UserEdadException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserEdadException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}