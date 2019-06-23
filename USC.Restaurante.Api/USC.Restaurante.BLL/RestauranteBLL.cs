using System.Collections.Generic;
using System.Threading.Tasks;
using USC.Restaurante.BLL.Infra;
using USC.Restaurante.DAL.Infra;
using USC.Restaurante.Erros;

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
            return _restauranteRepository.GetAllRestauranteAsync();
        }

        public Task<Entities.Restaurante> GetRestauranteAsync(long id)
        {
            if (id < 1)
                throw new ParametroInvalidoException("Identificador de restaurante inválido.", "id");

            var restaurante = _restauranteRepository.GetRestauranteAsync(id);

            if (restaurante == null)
                throw new ElementoNaoEncontratoException("Restaurante não encontrado.");

            return restaurante;               
        }

        public Task<Entities.Restaurante> PostRestauranteAsync(Entities.Restaurante restaurante)
        {
            return _restauranteRepository.PostRestauranteAsync(restaurante);
        }

        public Task<Entities.Restaurante> PutRestauranteAsync(Entities.Restaurante restaurante)
        {
            var restauranteExistente = _restauranteRepository.GetRestauranteAsync(restaurante.IdRestaurante);

            if (restauranteExistente == null)
                throw new ElementoNaoEncontratoException("Restaurante não encontrado.");

            return _restauranteRepository.PutRestauranteAsync(restaurante);
        }
    }
}
