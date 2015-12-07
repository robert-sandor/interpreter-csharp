using System;
using System.Runtime.Serialization;

namespace InterpreterCSharp.Source.exceptions.domain
{
    public class InputException : DomainException
    {
        public InputException()
        {
        }

        public InputException(string message) : base(message)
        {
        }

        public InputException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public InputException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}