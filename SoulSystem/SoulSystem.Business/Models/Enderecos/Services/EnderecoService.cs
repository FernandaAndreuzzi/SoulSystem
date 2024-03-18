using SoulSystem.Business.Core.Notifications;
using SoulSystem.Business.Core.Services;
using SoulSystem.Business.Models.Clientes;
using SoulSystem.Business.Models.Clientes.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Models.Enderecos.Services
{
    public class EnderecoService : BaseService, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;
        public EnderecoService(INotifier notificacao, IEnderecoRepository enderecoRepository) : base(notificacao)
        {
            _enderecoRepository = enderecoRepository;
        }
        public async Task Adicionar(Endereco endereco)
        {
            if (!ExecutarValidacao(new EnderecoValidacoes(), endereco)) return;

            if (await EnderecoExistente(endereco)) return;

            await _enderecoRepository.Adicionar(endereco);
        }

        public async Task Atualizar(Endereco endereco)
        {
            if (!ExecutarValidacao(new EnderecoValidacoes(), endereco)) return;

            if (await EnderecoExistente(endereco)) return;

            await _enderecoRepository.SalvarAlteracoes(endereco);
        }

        private async Task<bool> EnderecoExistente(Endereco endereco)
        {
            var enderecoAtual = await _enderecoRepository.Buscar(f => f.Cep == endereco.Cep && f.Id != endereco.Id);

            if (!enderecoAtual.Any()) return false;

            Notificar("Já existe um fornecedor com este documento infomado.");
            return true;
        }

        public void Dispose()
        {
            _enderecoRepository?.Dispose();
        }
    }
}
