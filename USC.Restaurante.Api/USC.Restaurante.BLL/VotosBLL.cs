using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using USC.Restaurante.BLL.Infra;
using USC.Restaurante.DAL.Infra;
using USC.Restaurante.Entities;
using USC.Restaurante.Erros;

namespace USC.Restaurante.BLL
{
    public class VotosBLL : IVotosBLL
    {
        private readonly IRestauranteRepository _restauranteRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUsuarioRestauranteRepository _usuarioRestauranteRepository;

        public VotosBLL
            (IRestauranteRepository restauranteRepository,
            IUsuarioRepository usuarioRepository,
            IUsuarioRestauranteRepository usuarioRestauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
            _usuarioRepository = usuarioRepository;
            _usuarioRestauranteRepository = usuarioRestauranteRepository;
        }

        public Task<List<UsuarioRestaurante>> GetVotosUsuario(long idUsuario, DateTime? dataHora)
        {
            if (idUsuario < 1)
                throw new ParametroInvalidoException("Identificador de usuário inválido.", "idUsuario");

            return _usuarioRestauranteRepository.GetAllRestauranteHistoricoUsuarioAsync(idUsuario, dataHora.Value);
        }

        public Task<UsuarioRestaurante> PostVotarAsync(long idRestaurante, long idUsuario)
        {
            ValidacaoDados(idRestaurante, idUsuario);

            var usuarioRestaurante = new UsuarioRestaurante()
            {
                IdRestaurante = idRestaurante,
                IdUsuario = idUsuario,
                DataHora = DateTime.Now
            };

            return _usuarioRestauranteRepository.PostUsuarioRestauranteAsync(usuarioRestaurante);
        }

        public Task<UsuarioRestaurante> PutVotarAsync(long idRestaurante, long idUsuario, long idUsuarioRestaurante)
        {
            ValidacaoDados(idRestaurante, idUsuario);

            if (idUsuarioRestaurante < 1)
                throw new ParametroInvalidoException("Identificador de usuário restaurante inválido.", "idUsuarioRestaurante");

            var usuarioRestaurante = _usuarioRestauranteRepository.GetUsuarioRestauranteAsync(idUsuarioRestaurante);

            if (usuarioRestaurante == null)
                throw new ElementoNaoEncontratoException("Voto não encontrado.");

            if (usuarioRestaurante.Result.IdUsuario != idUsuario)
                throw new ParametroInvalidoException("Voto não correspondente ao usuário.", "idUsuario");

            usuarioRestaurante.Result.DataHora = DateTime.Now;
            usuarioRestaurante.Result.IdRestaurante = idRestaurante;

            return _usuarioRestauranteRepository.PutUsuarioRestauranteAsync(usuarioRestaurante.Result);
        }

        private void ValidacaoDados(long idRestaurante, long idUsuario)
        {            
            if (DateTime.Now.Hour >= 12)
                throw new ParametroInvalidoException("Data maior que meio-dia", "dataHora");

            if (idRestaurante < 1)
                throw new ParametroInvalidoException("Identificador de restaurante inválido.", "idRestaurante");

            if (idUsuario < 1)
                throw new ParametroInvalidoException("Identificador de usuário inválido.", "idUsuario");

            var restaurante = _restauranteRepository.GetRestauranteAsync(idRestaurante);

            if (restaurante == null)
                throw new ElementoNaoEncontratoException("Restaurante não encontrado.");

            var usuario = _usuarioRepository.GetUsuarioAsync(idUsuario);

            if (usuario == null)
                throw new ElementoNaoEncontratoException("Usuário não encontrado.");
        }
    }
}
