using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USC.Restaurante.DAL.Infra;
using USC.Restaurante.Entities;

namespace USC.Restaurante.DAL
{
    public class PessoaRepository : RepositoryBase<IRestauranteDbContext>, IPessoaRepository
    {
        public PessoaRepository(IRestauranteDbContext dbContext) : base(dbContext)
        {
        }

        /// <summary>
        /// Método responsável por buscar todos as Pessoas
        /// </summary>
        /// <returns>Lista de objetos de Pessoa</returns>
        public async Task<List<Pessoa>> GetAllPessoaAsync()
        {
            return _dbContext.QueryPessoa.ToList();
        }

        /// <summary>
        /// Método resposável por buscar uma Pessoa específico
        /// </summary>
        /// <param name="id">Identificador do Pessoa</param>
        /// <returns>Objeto Pessoa</returns>
        public async Task<Pessoa> GetPessoaAsync(long id)
        {
            try
            {
                return _dbContext.QueryPessoa.Where(x => x.IdPessoa == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método responsável por inserir uma nova Pessoa
        /// </summary>
        /// <param name="pessoa">Objeto Pessoa</param>
        /// <returns>Objeto Pessoa</returns>
        public async Task<Pessoa> PostPessoaAsync(Pessoa pessoa)
        {
            try
            {
                if (!pessoa.ValidarEntidade())
                    throw new Exception("Pessoa inválida.");

                _dbContext.Add(pessoa);
                await _dbContext.SaveChangesAsync();

                return pessoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método responsável por alterar uma Pessoa
        /// </summary>
        /// <param name="pessoa">Objeto Pessoa</param>
        /// <returns>Objeto Pessoa</returns>
        public async Task<Pessoa> PutPessoaAsync(Pessoa pessoa)
        {
            try
            {
                _dbContext.SetModified(pessoa);
                await _dbContext.SaveChangesAsync();

                return pessoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}