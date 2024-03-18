 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Models.Pessoas.Services
{
    public interface IPessoaService: IDisposable
    {
        Task Adicionar(Pessoa pessoa);
        Task Atualizar(Pessoa pessoa);
    }
}
