using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USC.Restaurante.DAL.Infra;
using USC.Restaurante.Entities;

namespace USC.Restaurante.DAL
{
    public class RestauranteHistoricoRepository : RepositoryBase<IRestauranteDbContext>, IRestauranteHistoricoRepository
    {
        public RestauranteHistoricoRepository(IRestauranteDbContext dbContext) : base(dbContext)
        {
        }

        /// <summary>
        /// Método responsável por buscar todos os RestauranteHistorico
        /// </summary>
        /// <returns>Lista de objetos de RestauranteHistorico</returns>
        public async Task<List<RestauranteHistorico>> GetAllRestauranteHistoricoAsync()
        {
            return _dbContext.QueryRestauranteHistorico.ToList();
        }

        /// <summary>
        /// Método resposável por buscar um RestauranteHistorico específico
        /// </summary>
        /// <param name="id">Identificador do RestauranteHistorico</param>
        /// <returns>Objeto RestauranteHistorico</returns>
        public async Task<RestauranteHistorico> GetRestauranteHistoricoAsync(long id)
        {
            try
            {
                return _dbContext.QueryRestauranteHistorico.Where(x => x.IdRestauranteHist == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método responsável por inserir um novo RestauranteHistorico
        /// </summary>
        /// <param name="restauranteHistorico">Objeto RestauranteHistorico</param>
        /// <returns>Objeto RestauranteHistorico</returns>
        public async Task<RestauranteHistorico> PostRestauranteHistoricoAsync(RestauranteHistorico restauranteHistorico)
        {
            try
            {
                if (!restauranteHistorico.ValidarEntidade())
                    throw new Exception("Restaurante histórico inválido.");

                _dbContext.Add(restauranteHistorico);
                await _dbContext.SaveChangesAsync();

                return restauranteHistorico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método responsável por alterar um RestauranteHistorico
        /// </summary>
        /// <param name="restauranteHistorico">Objeto RestauranteHistorico</param>
        /// <returns>Objeto RestauranteHistorico</returns>
        public async Task<RestauranteHistorico> PutRestauranteHistoricoAsync(RestauranteHistorico restauranteHistorico)
        {
            try
            {
                _dbContext.SetModified(restauranteHistorico);
                await _dbContext.SaveChangesAsync();

                return restauranteHistorico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        
    }
}