using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using USC.Restaurante.Entities;

namespace USC.Restaurante.DAL.Infra
{
    public interface IUsuarioRestauranteRepository
    {
        Task<UsuarioRestaurante> GetUsuarioRestauranteAsync(long id);
        Task<List<UsuarioRestaurante>> GetAllUsuarioRestauranteAsync();
        Task<UsuarioRestaurante> PostUsuarioRestauranteAsync(UsuarioRestaurante usuarioRestaurante);
        Task<UsuarioRestaurante> PutUsuarioRestauranteAsync(UsuarioRestaurante usuarioRestaurante);
    }
}
