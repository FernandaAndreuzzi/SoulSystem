using SoulSystem.Business.Models.Pessoas;
using SoulSystem.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulSystem.Business.Models.Contatos;
using SoulSystem.Infra.Data.Context;
using System.Data.Entity;

namespace SoulSystem.Infra.Data.Repository
{
    public class ContatoRepository : Repository<Contato>, IContatoRepository
    {
        public ContatoRepository(SoulSystemContext db) : base(db)
        {
        }

        public async Task<IEnumerable<Contato>> ObterContatoPorNome(string nome) 
            => await Db.Contatos.Where(w=>w.Pessoa.Nome.ToUpper().Contains(nome.ToUpper())).ToListAsync();
        
    }
}
