using System;
using System.Runtime.Serialization;

namespace InterpreterCSharp.Source.exceptions.view
{
    public abstract class ViewException : InterpreterException
    {
        protected ViewException()
        {
        }

        protected ViewException(string message) : base(message)
        {
        }

        protected ViewException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ViewException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}