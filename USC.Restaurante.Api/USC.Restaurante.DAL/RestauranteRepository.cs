using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USC.Restaurante.DAL.Infra;

namespace USC.Restaurante.DAL
{
    public class RestauranteRepository : RepositoryBase<IRestauranteDbContext>, IRestauranteRepository
    {
        public RestauranteRepository(IRestauranteDbContext dbContext) : base(dbContext)
        {
        }

        /// <summary>
        /// Método responsável por buscar todos os Restaurante
        /// </summary>
        /// <returns>Lista de objetos de Restaurante</returns>
        public async Task<List<Entities.Restaurante>> GetAllRestauranteAsync()
        {
            return _dbContext.QueryRestaurante.ToList();
        }

        /// <summary>
        /// Método resposável por buscar um Restaurante específico
        /// </summary>
        /// <param name="id">Identificador do Restaurante</param>
        /// <returns>Objeto Restaurante</returns>
        public async Task<Entities.Restaurante> GetRestauranteAsync(long id)
        {
            try
            {
                return _dbContext.QueryRestaurante.Where(x => x.IdRestaurante == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método responsável por inserir um novo usuário
        /// </summary>
        /// <param name="restaurante">Objeto usuário</param>
        /// <returns>Objeto usuário</returns>
        public async Task<Entities.Restaurante> PostRestauranteAsync
            (Entities.Restaurante restaurante)
        {
            try
            {
                if (!restaurante.ValidarEntidade())
                    throw new Exception("Restaurante inválido.");

                _dbContext.Add(restaurante);
                await _dbContext.SaveChangesAsync();

                return restaurante;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método responsável por alterar um Restaurante
        /// </summary>
        /// <param name="restaurante">Objeto Restaurante</param>
        /// <returns>Objeto Restaurante</returns>
        public async Task<Entities.Restaurante> PutRestauranteAsync
            (Entities.Restaurante restaurante)
        {
            try
            {                
                _dbContext.SetModified(restaurante);
                await _dbContext.SaveChangesAsync();

                return restaurante;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
