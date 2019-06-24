using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using USC.Restaurante.Entities;

namespace USC.Restaurante.BLL.Infra
{
    public interface IVotosBLL
    {
        Task<UsuarioRestaurante> PostVotarAsync(long idRestaurante, long idUsuario);
        Task<UsuarioRestaurante> PutVotarAsync(long idRestaurante, long idUsuario, long idUsuarioRestaurante);
        Task<List<UsuarioRestaurante>> GetVotosUsuario(long idUsuario, DateTime? dataHora);
    }
}
