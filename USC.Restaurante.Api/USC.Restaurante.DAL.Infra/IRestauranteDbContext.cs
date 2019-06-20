using System.Linq;
using USC.Restaurante.Entities;

namespace USC.Restaurante.DAL.Infra
{
    public interface IRestauranteDbContext : IDataBaseContext
    {
        IQueryable<Usuario> QueryUsuario { get; }
    }
}
