using System;
using System.Runtime.Serialization;

namespace InterpreterCSharp.Source.exceptions
{
    public abstract class InterpreterException : Exception
    {
        protected InterpreterException()
        {
        }

        protected InterpreterException(string message) : base(message)
        {
        }

        protected InterpreterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InterpreterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}