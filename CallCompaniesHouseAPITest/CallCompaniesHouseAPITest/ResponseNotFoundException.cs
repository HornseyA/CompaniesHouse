using System;
using System.Runtime.Serialization;

namespace CallCompaniesHouseAPITest
{
    [Serializable]
    internal class ResponseNotFoundException : Exception
    {
        private Exception e;

        public ResponseNotFoundException()
        {
        }

        public ResponseNotFoundException(Exception e)
        {
            this.e = e;
        }

        public ResponseNotFoundException(string message) : base(message)
        {
        }

        public ResponseNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ResponseNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
