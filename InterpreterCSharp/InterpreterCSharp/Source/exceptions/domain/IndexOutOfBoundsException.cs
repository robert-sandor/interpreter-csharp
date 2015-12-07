using System;
using System.Runtime.Serialization;

namespace InterpreterCSharp.Source.exceptions.domain
{
    public class IndexOutOfBoundsException : DomainException
    {
        public IndexOutOfBoundsException()
        {
        }

        public IndexOutOfBoundsException(string message) : base(message)
        {
        }

        public IndexOutOfBoundsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public IndexOutOfBoundsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}