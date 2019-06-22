using System.Collections.Generic;
using System.Threading.Tasks;
using USC.Restaurante.BLL.Infra;
using USC.Restaurante.DAL.Infra;

namespace USC.Restaurante.BLL
{
    public class RestauranteBLL : IRestauranteBLL
    {
        private readonly IRestauranteRepository _restauranteRepository;

        public RestauranteBLL(IRestauranteRepository restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }

        public Task<List<Entities.Restaurante>> GetAllRestauranteAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Entities.Restaurante> GetRestauranteAsync(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Entities.Restaurante> PostRestauranteAsync(Entities.Restaurante restaurante)
        {
            throw new System.NotImplementedException();
        }

        public Task<Entities.Restaurante> PutRestauranteAsync(Entities.Restaurante restaurante)
        {
            throw new System.NotImplementedException();
        }
    }
}
