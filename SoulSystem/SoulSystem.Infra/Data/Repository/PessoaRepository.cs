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
    }
}
