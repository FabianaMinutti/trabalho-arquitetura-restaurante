using System.Collections.Generic;
using System.Threading.Tasks;
using USC.Restaurante.Entities;

namespace USC.Restaurante.DAL.Infra
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetUsuarioAsync(long id);
        Task<Usuario> GetUsuarioByLoginAsync(string login);
        Task<List<Usuario>> GetAllUsuarioAsync();
        Task<Usuario> PostUsuarioAsync(Usuario usuario);
        Task<Usuario> PutUsuarioAsync(Usuario usuario);
    }
}
