using System.Collections.Generic;
using System.Threading.Tasks;
using USC.Restaurante.Entities;

namespace USC.Restaurante.DAL.Infra
{
    public interface IRestauranteHistoricoRepository
    {
        Task<RestauranteHistorico> GetRestauranteHistoricoAsync(long id);
        Task<List<RestauranteHistorico>> GetAllRestauranteHistoricoAsync();
        Task<RestauranteHistorico> PostRestauranteHistoricoAsync(RestauranteHistorico restauranteHistorico);
        Task<RestauranteHistorico> PutRestauranteHistoricoAsync(RestauranteHistorico restauranteHistorico);
    }
}
