using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using USC.Restaurante.BLL.Infra;
using USC.Restaurante.Entities;

namespace USC.Restaurante.BLL
{
    public class VotosBLL : IVotosBLL
    {
        public Task<List<UsuarioRestaurante>> GetVotosUsuario(long idUsuario, DateTime? dataHora)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostVotarAsync(long idRestaurante, long idUsuario, DateTime dataHora)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutVotarAsync(long idRestaurante, long idUsuario, DateTime dataHora)
        {
            throw new NotImplementedException();
        }
    }
}
