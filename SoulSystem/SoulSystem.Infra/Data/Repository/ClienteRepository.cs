using SoulSystem.Business.Models.Pessoas;
using SoulSystem.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulSystem.Business.Models.Clientes;
using SoulSystem.Infra.Data.Context;

namespace SoulSystem.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(SoulSystemContext db) : base(db)
        {
        }
    }
}
