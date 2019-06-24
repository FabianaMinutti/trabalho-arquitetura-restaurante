using System.Collections.Generic;
using System.Threading.Tasks;
using USC.Restaurante.BLL.Infra;
using USC.Restaurante.DAL.Infra;
using USC.Restaurante.Entities;
using USC.Restaurante.Erros;

namespace USC.Restaurante.BLL
{
    public class UsuarioBLL : IUsuarioBLL
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IPessoaRepository _pessoaRepository;

        public UsuarioBLL
            (IUsuarioRepository usuarioRepository,
            IPessoaRepository pessoaRepository)
        {
            _usuarioRepository = usuarioRepository;
            _pessoaRepository = pessoaRepository;
        }

        /// <summary>
        /// Método responsável pela validação dos dados para a consulta de 
        /// todos os usuários
        /// </summary>
        /// <returns>Lista de objetos de usuários</returns>
        public Task<List<Usuario>> GetAllUsuarioAsync()
        {
            return _usuarioRepository.GetAllUsuarioAsync();
        }

        /// <summary>
        /// Método responsável pela validação dos dados para a consulta de
        /// um usuário específico
        /// </summary>
        /// <param name="id">Identificador do usuário</param>
        /// <returns>Objeto usuário</returns>
        public Task<Usuario> GetUsuarioAsync(long id)
        {
            if (id < 1)
                throw new ParametroInvalidoException("Identificador usuário inválido", "id");

            var usuario = _usuarioRepository.GetUsuarioAsync(id);

            if (usuario == null)
                throw new ElementoNaoEncontratoException("Usuário não encontrado.");

            return usuario;
        }

        /// <summary>
        /// Método responsável pela validação dos dados para a inclusão de
        /// um novo usuário
        /// </summary>
        /// <param name="usuario">Objeto usuário</param>
        /// <returns>Objeto usuário</returns>
        public async Task<Usuario> PostUsuarioAsync(Usuario usuario, Pessoa pessoa)
        {
            var pessoaNova = _pessoaRepository.PostPessoaAsync(pessoa);
            usuario.IdPessoa = pessoaNova.Id;

            return await _usuarioRepository.PostUsuarioAsync(usuario);
        }

        /// <summary>
        /// Método responsável pela validação dos dados para alteração de
        /// um usuário existente
        /// </summary>
        /// <param name="usuario">Objeto usuário</param>
        /// <returns>Objeto usuário</returns>
        public Task<Usuario> PutUsuarioAsync(Usuario usuario)
        {
            var usuarioExistente = _usuarioRepository.GetUsuarioAsync(usuario.IdUsuario);

            if (usuarioExistente == null)
                throw new ElementoNaoEncontratoException("Usuário não encontrado.");

            return _usuarioRepository.PutUsuarioAsync(usuario);
        }
    }
}
