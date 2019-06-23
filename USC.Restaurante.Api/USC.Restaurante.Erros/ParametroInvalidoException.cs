using System;
using System.Runtime.Serialization;

namespace USC.Restaurante.Erros
{
    /// <summary> 
    /// Exceção que é gerada quando os parâmetros de entrada estão num estado inválido para a chamada.
    /// </summary>
    public class ParametroInvalidoException : ArgumentException
    {
        public ParametroInvalidoException() : base() { }

        public ParametroInvalidoException(string message) : base(message) { }

        public ParametroInvalidoException(string message, Exception innerException) : base(message, innerException) { }

        public ParametroInvalidoException(string message, string paramName) : base(message, paramName) { }

        public ParametroInvalidoException(string message, string paramName, Exception innerException) : base(message, paramName, innerException) { }

        protected ParametroInvalidoException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
