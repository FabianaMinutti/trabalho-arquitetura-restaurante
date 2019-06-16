using System.Collections.Generic;

namespace USC.Restaurante.Interfaces
{
    public interface IEntity
    {
        bool ValidarEntidade();
        IEnumerable<string> VerificarMensagens();
    }
}
