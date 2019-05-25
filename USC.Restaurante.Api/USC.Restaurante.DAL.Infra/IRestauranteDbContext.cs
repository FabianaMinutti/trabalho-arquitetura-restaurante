using System.Linq;
using USC.Restaurante.Entities;

namespace USC.Restaurante.DAL.Infra
{
    public interface IRestauranteDbContext
    {
        IQueryable<Usuario> QueryUsuario { get; }
    }
}
