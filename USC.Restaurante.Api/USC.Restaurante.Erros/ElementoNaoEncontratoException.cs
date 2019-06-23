using System;
using System.Runtime.Serialization;

namespace USC.Restaurante.Erros
{
    /// <summary> 
    /// Exceção que é gerada quando o elemento requerido não é encontrado no repositório. 
    /// </summary>
    public class ElementoNaoEncontratoException : Exception
    {
        public ElementoNaoEncontratoException() : base() { }

        public ElementoNaoEncontratoException(string message) : base(message) { }

        public ElementoNaoEncontratoException(string message, Exception innerException) : base(message, innerException) { }

        protected ElementoNaoEncontratoException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}