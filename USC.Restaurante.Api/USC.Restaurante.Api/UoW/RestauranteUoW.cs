using USC.Restaurante.Api.UoW.Infra;
using USC.Restaurante.BLL.Infra;

namespace USC.Restaurante.Api.UoW
{
    public class RestauranteUoW : IRestautanteUoW
    {
        public IRestauranteBLL restauranteBLL { get; }

        public RestauranteUoW(IRestauranteBLL restauranteBLL)
        {
            this.restauranteBLL = restauranteBLL;
        }
    }
}