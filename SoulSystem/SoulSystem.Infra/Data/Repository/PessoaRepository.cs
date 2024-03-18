using SoulSystem.Business.Models;
using SoulSystem.Business.Models.Pessoas;
using SoulSystem.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Infra.Data.Repository
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(SoulSystemContext db) : base(db)
        {
        }
        public async Task<List<Pessoa>> BuscarPorNome(string nome)
        {
            return await Db.Pessoas.Where(w => w.Nome.ToUpper().Contains(nome.ToUpper())).ToListAsync();
        }

        public async Task<Pessoa> ObterPessoaPorCpf(string cpf)
        {
            return await Db.Pessoas.Where(w => w.Cpf.ToUpper().Contains(cpf.ToUpper())).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Pessoa>> ObterPessoaPorNome(string nome)
        {
            return await Db.Pessoas.Where(w => w.Nome.ToUpper().Contains(nome.ToUpper())).ToListAsync();
        }

        public async Task<Pessoa> ObterPorId(Pessoa pessoa)
        {
            return await Db.Pessoas.Where(w => w.Id == pessoa.Id).FirstOrDefaultAsync();
        }

        async Task<List<Pessoa>> IPessoaRepository.ObterPessoaPorNome(string nome) => await Db.Pessoas.Where(w=>w.Nome.ToUpper().Contains(nome.ToUpper())).ToListAsync();    
    }
}
