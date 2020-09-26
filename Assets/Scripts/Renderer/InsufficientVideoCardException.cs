using System;
using System.Runtime.Serialization;

namespace Earth.Renderer
{
    [Serializable]
    public class InsufficientVideoCardException : Exception
    {
        public InsufficientVideoCardException()
        {
        }

        public InsufficientVideoCardException(string message)
            : base(message)
        {
        }

        public InsufficientVideoCardException(string message, Exception inner)
            : base(message, inner) 
        {
        }

        protected InsufficientVideoCardException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
