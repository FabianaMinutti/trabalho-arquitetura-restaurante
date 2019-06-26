using System.Threading.Tasks;
using USC.Restaurante.Entities;

namespace USC.Restaurante.BLL.Infra
{
    public interface IAutenticadorBLL
    {
        public Task<Usuario> PostAutenticaAsync(Usuario usuario);
    }
}
