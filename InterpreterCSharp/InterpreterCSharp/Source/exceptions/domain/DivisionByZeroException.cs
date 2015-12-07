using System;
using System.Runtime.Serialization;

namespace InterpreterCSharp.Source.exceptions.domain
{
    public class DivisionByZeroException : DomainException
    {
        public DivisionByZeroException()
        {
        }

        public DivisionByZeroException(string message) : base(message)
        {
        }

        public DivisionByZeroException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public DivisionByZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}