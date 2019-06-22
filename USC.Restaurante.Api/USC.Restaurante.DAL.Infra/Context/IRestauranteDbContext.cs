using System.Linq;
using USC.Restaurante.Entities;

namespace USC.Restaurante.DAL.Infra
{
    public interface IRestauranteDbContext : IDataBaseContext
    {
        IQueryable<Usuario> QueryUsuario { get; }
        IQueryable<Pessoa> QueryPessoa { get; }
        IQueryable<USC.Restaurante.Entities.Restaurante> QueryRestaurante { get; }
        IQueryable<RestauranteHistorico> QueryRestauranteHistorico { get; }
        IQueryable<UsuarioRestaurante> QueryUsuarioRestaurante { get; }
    }
}
