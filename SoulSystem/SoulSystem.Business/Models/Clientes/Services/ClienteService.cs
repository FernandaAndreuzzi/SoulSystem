using SoulSystem.Business.Core.Notifications;
using SoulSystem.Business.Core.Services;
using SoulSystem.Business.Models.Clientes.Repository;
using SoulSystem.Business.Models.Enderecos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Models.Clientes.Services
{
    public class ClienteService : BaseService, IClienteService
    {
        private readonly IClienteRepository _clienteRepository; 
       public ClienteService(INotifier notificacao, IClienteRepository clienteRepository):base (notificacao)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task Adicionar(Cliente cliente)
        {
            if (!ExecutarValidacao(new ClienteValidacoes(), cliente)) return;
           
            if (await ClienteExistente(cliente)) return;
            
            await _clienteRepository.Adicionar(cliente);
        }

        public async Task Atualizar(Cliente cliente)
        {
            if (!ExecutarValidacao(new ClienteValidacoes(), cliente)) return;

            if (await ClienteExistente(cliente)) return;

            await _clienteRepository.SalvarAlteracoes(cliente);
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        private async Task<bool> ClienteExistente(Cliente cliente)
        {
            var clienteAtual = await _clienteRepository.Buscar(f => f.Pessoa == cliente.Pessoa && f.Id != cliente.Id);

            if (!clienteAtual.Any()) return false;

            Notificar("Cadastro de pessoa já existente.");
            return true;
        }
        public void Dispose()
        {
            _clienteRepository?.Dispose();
        }
    }
}
