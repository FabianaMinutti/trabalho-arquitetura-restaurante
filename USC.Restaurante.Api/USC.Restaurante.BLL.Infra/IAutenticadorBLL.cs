using System.Threading.Tasks;
using USC.Restaurante.Entities;

namespace USC.Restaurante.BLL.Infra
{
    public interface IAutenticadorBLL
    {
        Task<Usuario> PostAutenticaAsync(Usuario usuario);
    }
}
