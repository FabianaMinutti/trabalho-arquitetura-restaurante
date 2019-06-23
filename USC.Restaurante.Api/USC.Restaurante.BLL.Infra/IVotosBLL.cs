using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using USC.Restaurante.Entities;

namespace USC.Restaurante.BLL.Infra
{
    public interface IVotosBLL
    {
        Task<bool> PostVotarAsync(long idRestaurante, long idUsuario, DateTime dataHora);
        Task<bool> PutVotarAsync(long idRestaurante, long idUsuario, DateTime dataHora);
        Task<List<UsuarioRestaurante>> GetVotosUsuario(long idUsuario, DateTime? dataHora);
    }
}
