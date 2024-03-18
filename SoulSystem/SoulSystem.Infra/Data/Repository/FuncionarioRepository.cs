using SoulSystem.Business.Models.Pessoas;
using SoulSystem.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulSystem.Business.Models.Funcionarios;
using SoulSystem.Infra.Data.Context;
using System.Data.Entity;

namespace SoulSystem.Infra.Data.Repository
{
    public class FuncionarioRepository : Repository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(SoulSystemContext db) : base(db)
        {
        }

        public async Task<IEnumerable<Cliente>> ObterFuncionarioPorNome(string nome) 
            => await Db.Clientes.Where(w=>w.Pessoa.Nome.ToUpper().Contains(nome.ToUpper())).ToListAsync();
    }
}
