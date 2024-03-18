using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Models.Contatos.Services
{
    public interface IContatoService : IDisposable
    {
        Task Adicionar(Contato contato);
        Task Atualizar(Contato contato);
    }
}
