using System;
using System.Runtime.Serialization;
using InterpreterCSharp.Source.exceptions.view;

namespace InterpreterCSharp.Source.exceptions.controller
{
    public abstract class ControllerException : ViewException
    {
        protected ControllerException()
        {
        }

        protected ControllerException(string message) : base(message)
        {
        }

        protected ControllerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ControllerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}