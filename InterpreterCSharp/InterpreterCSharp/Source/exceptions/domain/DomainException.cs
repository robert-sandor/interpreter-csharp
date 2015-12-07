using System;
using System.Runtime.Serialization;
using InterpreterCSharp.Source.exceptions.repository;

namespace InterpreterCSharp.Source.exceptions.domain
{
    public abstract class DomainException : RepositoryException
    {
        protected DomainException()
        {
        }

        protected DomainException(string message) : base(message)
        {
        }

        protected DomainException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DomainException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}