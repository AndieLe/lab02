using System;
using System.Runtime.Serialization;

namespace LeTAnhDieu_1711061517.Controllers
{
    [Serializable]
    internal class RetryLimitExceedException : Exception
    {
        public RetryLimitExceedException()
        {
        }

        public RetryLimitExceedException(string message) : base(message)
        {
        }

        public RetryLimitExceedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RetryLimitExceedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}