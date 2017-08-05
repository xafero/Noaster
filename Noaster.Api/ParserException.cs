﻿using System;
using System.Runtime.Serialization;

namespace Noaster.Api
{

    [Serializable]
    public class ParserException : Exception
    {
        public ParserException() : base()
        {
        }

        public ParserException(string message) : base(message)
        {
        }

        public ParserException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ParserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}