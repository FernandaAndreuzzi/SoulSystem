using SoulSystem.Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Models.Pessoas
{
    public interface IPessoaRepository : IRepository<Pessoa>
    {
        Task<List<Pessoa>> ObterPessoaPorNome(string nome);
        Task<Pessoa> ObterPessoaPorCpf(string cpf);
        Task<Pessoa> ObterPorId(Pessoa pessoa);
    }
}
