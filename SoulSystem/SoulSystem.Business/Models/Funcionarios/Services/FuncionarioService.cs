using SoulSystem.Business.Core.Notifications;
using SoulSystem.Business.Core.Services;
using SoulSystem.Business.Models.Contatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Models.Funcionarios.Services
{
    public class FuncionarioService: BaseService, IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        public FuncionarioService(INotifier notificacao,IFuncionarioRepository funcionarioRepository):base(notificacao)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public async Task Adicionar(Funcionario funcionario)
        {
            if (!ExecutarValidacao(new FuncionarioValidacoes(), funcionario)) return;

            if (await FuncionarioExistente(funcionario)) return;

            await _funcionarioRepository.Adicionar(funcionario);
        }

        public async Task Atualizar(Funcionario funcionario)
        {
            if (!ExecutarValidacao(new FuncionarioValidacoes(), funcionario)) return;

            if (await FuncionarioExistente(funcionario)) return;
            
            await _funcionarioRepository.SalvarAlteracoes(funcionario);
        }
        private async Task<bool> FuncionarioExistente(Funcionario funcionario)
        {
            var funcionarioAtual = await _funcionarioRepository.Buscar(f => f.Id == funcionario.Id && f.Id != funcionario.Id);

            if (!funcionarioAtual.Any()) return false;

            Notificar("Já existe uma funcionario com este Id informado.");
            return true;
        }
        public void Dispose()
        {
            _funcionarioRepository?.Dispose();
        }
    }
}

