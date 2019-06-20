using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using USC.Restaurante.DAL.Infra;
using USC.Restaurante.Entities;

namespace USC.Restaurante.DAL
{
    public class UsuarioRepository : RepositoryBase<IRestauranteDbContext>, IUsuarioRepository
    {
        public UsuarioRepository(IRestauranteDbContext dbContext) : base(dbContext)
        {
        }

        /// <summary>
        /// Método responsável por buscar todos os usuários
        /// </summary>
        /// <returns>Lista de objetos de usuários</returns>
        public Task<List<Usuario>> GetAllUsuarioAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método resposável por buscar um usuário específico
        /// </summary>
        /// <param name="id">Identificador do usuário</param>
        /// <returns>Objeto usuário</returns>
        public Task<Usuario> GetUsuarioAsync(long id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método responsável por inserir um novo usuário
        /// </summary>
        /// <param name="usuario">Objeto usuário</param>
        /// <returns>Objeto usuário</returns>
        public Task<Usuario> PostUsuarioAsync(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método responsável por alterar um usuário
        /// </summary>
        /// <param name="usuario">Objeto usuário</param>
        /// <returns>Objeto usuário</returns>
        public Task<Usuario> PutUsuarioAsync(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
