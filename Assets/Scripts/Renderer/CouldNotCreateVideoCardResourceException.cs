using System;
using System.Runtime.Serialization;

namespace Earth.Renderer
{
    [Serializable]
    public class CouldNotCreateVideoCardResourceException : Exception
    {
        public CouldNotCreateVideoCardResourceException()
        {
        }

        public CouldNotCreateVideoCardResourceException(string message)
            : base(message)
        {
        }

        public CouldNotCreateVideoCardResourceException(string message, Exception inner)
            : base(message, inner) 
        {
        }

        protected CouldNotCreateVideoCardResourceException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
