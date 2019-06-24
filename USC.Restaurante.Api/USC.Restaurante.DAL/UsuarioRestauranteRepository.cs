using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USC.Restaurante.DAL.Infra;
using USC.Restaurante.Entities;

namespace USC.Restaurante.DAL
{
    public class UsuarioRestauranteRepository : RepositoryBase<IRestauranteDbContext>, IUsuarioRestauranteRepository
    {
        public UsuarioRestauranteRepository(IRestauranteDbContext dbContext) : base(dbContext)
        {
        }

        /// <summary>
        /// Método responsável por buscar todos os UsuarioRestaurante
        /// </summary>
        /// <returns>Lista de objetos de UsuarioRestaurante</returns>
        public async Task<List<UsuarioRestaurante>> GetAllUsuarioRestauranteAsync()
        {
            return _dbContext.QueryUsuarioRestaurante.ToList();
        }

        /// <summary>
        /// Método resposável por buscar um UsuarioRestaurante específico
        /// </summary>
        /// <param name="id">Identificador do UsuarioRestaurante</param>
        /// <returns>Objeto UsuarioRestaurante</returns>
        public async Task<UsuarioRestaurante> GetUsuarioRestauranteAsync(long id)
        {
            try
            {
                return _dbContext.QueryUsuarioRestaurante.Where(x => x.IdUsuarioRestaurante == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método responsável por inserir um novo UsuarioRestaurante
        /// </summary>
        /// <param name="usuarioRestaurante">Objeto UsuarioRestaurante</param>
        /// <returns>Objeto UsuarioRestaurante</returns>
        public async Task<UsuarioRestaurante> PostUsuarioRestauranteAsync(UsuarioRestaurante usuarioRestaurante)
        {
            try
            {
                _dbContext.Add(usuarioRestaurante);
                await _dbContext.SaveChangesAsync();

                return usuarioRestaurante;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método responsável por alterar um UsuarioRestaurante
        /// </summary>
        /// <param name="usuarioRestaurante">Objeto UsuarioRestaurante</param>
        /// <returns>Objeto usuário</returns>
        public async Task<UsuarioRestaurante> PutUsuarioRestauranteAsync(UsuarioRestaurante usuarioRestaurante)
        {
            try
            {
                _dbContext.SetModified(usuarioRestaurante);
                await _dbContext.SaveChangesAsync();

                return usuarioRestaurante;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<UsuarioRestaurante>> GetAllRestauranteHistoricoUsuarioAsync(long idUsuario, DateTime? dataHora)
        {
            try
            {
                var retorno = _dbContext.QueryUsuarioRestaurante.Where(x => x.IdUsuario == idUsuario);

                if (dataHora.HasValue)
                    retorno = retorno.Where(x => x.DataHora == dataHora);

                return retorno.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
