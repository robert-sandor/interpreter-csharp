using System;
using System.Runtime.Serialization;
using InterpreterCSharp.Source.exceptions.controller;

namespace InterpreterCSharp.Source.exceptions.repository
{
    public abstract class RepositoryException : ControllerException
    {
        protected RepositoryException()
        {
        }

        protected RepositoryException(string message) : base(message)
        {
        }

        protected RepositoryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}