using System;
using System.Runtime.Serialization;

namespace InterpreterCSharp.Source.exceptions.domain
{
    public class EmptyStackException : DomainException
    {
        public EmptyStackException()
        {
        }

        public EmptyStackException(string message) : base(message)
        {
        }

        public EmptyStackException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public EmptyStackException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}