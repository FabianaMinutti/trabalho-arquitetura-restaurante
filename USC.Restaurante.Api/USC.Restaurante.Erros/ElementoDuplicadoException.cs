using System;
using System.Runtime.Serialization;

namespace USC.Restaurante.Erros
{
    /// <summary> 
    /// Exceção que é gerada ao tentar inserir um elemento duplicado no repositório. 
    /// </summary>
    public class ElementoDuplicadoException : Exception
    {
        public ElementoDuplicadoException() : base() { }

        public ElementoDuplicadoException(string message) : base(message) { }

        public ElementoDuplicadoException(string message, Exception innerException) : base(message, innerException) { }

        protected ElementoDuplicadoException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}