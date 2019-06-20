using System.Collections.Generic;
using System.Threading.Tasks;
using USC.Restaurante.Entities;

namespace USC.Restaurante.BLL.Infra
{
    public interface IUsuarioBLL
    {
        Task<Usuario> GetUsuarioAsync(long id);
        Task<List<Usuario>> GetAllUsuarioAsync();
        Task<Usuario> PostUsuarioAsync(Usuario usuario);
        Task<Usuario> PutUsuarioAsync(Usuario usuario);
    }
}
