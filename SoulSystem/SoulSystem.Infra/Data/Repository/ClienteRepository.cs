using SoulSystem.Business.Models.Pessoas;
using SoulSystem.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulSystem.Business.Models.Clientes;
using SoulSystem.Infra.Data.Context;
using SoulSystem.Business.Models.Clientes.Repository;
using SoulSystem.Business.Core.Notifications;
using System.Data.Entity;

namespace SoulSystem.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {

        public ClienteRepository(INotifier notificacao, SoulSystemContext db) : base(db)
        {
        }

        public async Task<IEnumerable<Cliente>> ObterClientePorNome(string nome) 
            => await Db.Clientes.Where(w=>w.Pessoa.Nome.ToUpper().Contains(nome)).ToListAsync();
        
    }
}
