using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<List<Usuario>> GetAllUsuarioAsync()
        {
            return _dbContext.QueryUsuario.ToList();
        }

        /// <summary>
        /// Método resposável por buscar um usuário específico
        /// </summary>
        /// <param name="id">Identificador do usuário</param>
        /// <returns>Objeto usuário</returns>
        public async Task<Usuario> GetUsuarioAsync(long id)
        {
            try
            {
                return _dbContext.QueryUsuario.Where(x => x.IdUsuario == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método responsável por inserir um novo usuário
        /// </summary>
        /// <param name="usuario">Objeto usuário</param>
        /// <returns>Objeto usuário</returns>
        public async Task<Usuario> PostUsuarioAsync(Usuario usuario)
        {
            try
            {
                _dbContext.Add(usuario);
                await _dbContext.SaveChangesAsync();

                return usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método responsável por alterar um usuário
        /// </summary>
        /// <param name="usuario">Objeto usuário</param>
        /// <returns>Objeto usuário</returns>
        public async Task<Usuario> PutUsuarioAsync(Usuario usuario)
        {
            try
            {
                _dbContext.SetModified(usuario);
                await _dbContext.SaveChangesAsync();

                return usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
