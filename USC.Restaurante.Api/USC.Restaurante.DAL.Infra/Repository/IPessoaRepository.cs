using System.Collections.Generic;
using System.Threading.Tasks;
using USC.Restaurante.Entities;

namespace USC.Restaurante.DAL.Infra
{
    public interface IPessoaRepository
    {
        Task<Pessoa> GetPessoaAsync(long id);
        Task<List<Pessoa>> GetAllPessoaAsync();
        Task<Pessoa> PostPessoaAsync(Pessoa pessoa);
        Task<Pessoa> PutPessoaAsync(Pessoa pessoa);
    }
}
