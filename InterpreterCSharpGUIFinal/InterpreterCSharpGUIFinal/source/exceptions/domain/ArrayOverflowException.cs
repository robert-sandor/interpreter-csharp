using System;
using System.Runtime.Serialization;

namespace InterpreterCSharp.Source.exceptions.domain
{
    public class ArrayOverflowException : DomainException
    {
        public ArrayOverflowException()
        {
        }

        public ArrayOverflowException(string message) : base(message)
        {
        }

        public ArrayOverflowException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ArrayOverflowException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}