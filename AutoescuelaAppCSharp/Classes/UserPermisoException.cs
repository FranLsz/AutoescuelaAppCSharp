using System;
using System.Runtime.Serialization;

namespace AutoescuelaAppCSharp.Classes
{
    [Serializable]
    internal class UserPermisoException : Exception
    {
        public UserPermisoException()
        {
        }

        public UserPermisoException(string message) : base(message)
        {
        }

        public UserPermisoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserPermisoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}