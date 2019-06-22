using System.Collections.Generic;
using System.Threading.Tasks;

namespace USC.Restaurante.BLL.Infra
{
    public interface IRestauranteBLL
    {
        Task<USC.Restaurante.Entities.Restaurante> GetRestauranteAsync(long id);
        Task<List<USC.Restaurante.Entities.Restaurante>> GetAllRestauranteAsync();
        Task<USC.Restaurante.Entities.Restaurante> PostRestauranteAsync(USC.Restaurante.Entities.Restaurante restaurante);
        Task<USC.Restaurante.Entities.Restaurante> PutRestauranteAsync(USC.Restaurante.Entities.Restaurante restaurante);
    }
}
