using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using USC.Restaurante.BLL.Infra;
using USC.Restaurante.DAL.Infra;
using USC.Restaurante.Entities;

namespace USC.Restaurante.BLL
{
    public class UsuarioBLL : IUsuarioBLL
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioBLL(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        /// <summary>
        /// Método responsável pela validação dos dados para a consulta de 
        /// todos os usuários
        /// </summary>
        /// <returns>Lista de objetos de usuários</returns>
        public Task<List<Usuario>> GetAllUsuarioAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método responsável pela validação dos dados para a consulta de
        /// um usuário específico
        /// </summary>
        /// <param name="id">Identificador do usuário</param>
        /// <returns>Objeto usuário</returns>
        public Task<Usuario> GetUsuarioAsync(long id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método responsável pela validação dos dados para a inclusão de
        /// um novo usuário
        /// </summary>
        /// <param name="usuario">Objeto usuário</param>
        /// <returns>Objeto usuário</returns>
        public async Task<Usuario> PostUsuarioAsync(Usuario usuario)
        {
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
            throw new NotImplementedException();
        }
    }
}
