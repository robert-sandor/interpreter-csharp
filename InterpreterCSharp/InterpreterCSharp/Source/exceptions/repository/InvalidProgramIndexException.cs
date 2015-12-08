using System;
using System.Runtime.Serialization;

namespace InterpreterCSharp.Source.exceptions.repository
{
    public class InvalidProgramIndexException : RepositoryException
    {
        public InvalidProgramIndexException()
        {
        }

        public InvalidProgramIndexException(string message) : base(message)
        {
        }

        public InvalidProgramIndexException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public InvalidProgramIndexException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}