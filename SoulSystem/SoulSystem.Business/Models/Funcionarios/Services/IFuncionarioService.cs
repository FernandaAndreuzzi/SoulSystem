using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Models.Funcionarios.Services
{
    public interface IFuncionarioService: IDisposable
    {
        Task Adicionar(Funcionario funcionario);
        Task Atualizar(Funcionario funcionario);
    }
}
