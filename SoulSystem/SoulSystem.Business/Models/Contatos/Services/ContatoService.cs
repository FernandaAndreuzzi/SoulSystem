using SoulSystem.Business.Core.Notifications;
using SoulSystem.Business.Core.Services;
using SoulSystem.Business.Models.Clientes;
using SoulSystem.Business.Models.Clientes.Repository;
using SoulSystem.Business.Models.Enderecos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Models.Contatos.Services
{
    public class ContatoService : BaseService, IContatoService
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoService(INotifier notificador,IContatoRepository contatoRepository) : base(notificador)
        {
            _contatoRepository = contatoRepository;
        }

        public async Task Adicionar(Contato contato)
        {
            if (!ExecutarValidacao(new ContatoValidacoes(), contato)) return;

            await _contatoRepository.Adicionar(contato);
        }

        public async Task Atualizar(Contato contato)
        {
            if (!ExecutarValidacao(new ContatoValidacoes(), contato)) return;

            await _contatoRepository.SalvarAlteracoes(contato);
        }

        public void Dispose()
        {
            _contatoRepository?.Dispose();
        }
    }
}
