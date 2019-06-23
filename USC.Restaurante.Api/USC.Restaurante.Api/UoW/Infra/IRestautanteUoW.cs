using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USC.Restaurante.BLL.Infra;

namespace USC.Restaurante.Api.UoW.Infra
{
    public interface IRestautanteUoW
    {
        IRestauranteBLL restauranteBLL { get; }
    }
}
