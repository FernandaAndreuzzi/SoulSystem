using SoulSystem.Business.Core.Notifications;
using SoulSystem.Business.Core.Services;
using SoulSystem.Business.Models.Contatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Models.Pessoas.Services
{
    public class PessoaService : BaseService, IPessoaRepository
    {
        private readonly IPessoaRepository _pessoaRepository;
        public PessoaService(INotifier notificador, IPessoaRepository PessoaRepository):base(notificador)
        {
            _pessoaRepository = PessoaRepository;
        }
        public async Task Adicionar(Pessoa pessoa)
        {
            if (!ExecutarValidacao(new PessoaValidacoes(), pessoa)) return;

            if (await PessoaExistente(pessoa)) return;

            await _pessoaRepository.Adicionar(pessoa);
        }
        public async Task SalvarAlteracoes(Pessoa pessoa)
        {
            if (!ExecutarValidacao(new PessoaValidacoes(), pessoa)) return;

            if (await PessoaExistente(pessoa)) return;

            await _pessoaRepository.SalvarAlteracoes(pessoa);
        }
        private async Task<bool> PessoaExistente(Pessoa pessoa)
        {
            var pessoaAtual = await _pessoaRepository.Buscar(f => f.Cpf == pessoa.Cpf && f.Id != pessoa.Id);

            if (!pessoaAtual.Any()) return false;

            Notificar("Já existe uma pessoa com este CPF infomado.");
            return true;
        }
        
        public async Task<Pessoa> ObterPessoaPorCpf(string cpf) => await _pessoaRepository.ObterPessoaPorCpf(cpf);

        public async Task<IEnumerable<Pessoa>> ObterPessoaPorNome(string nome) => await _pessoaRepository.ObterPessoaPorNome(nome);

        public async Task<List<Pessoa>> ObterTodos() => await _pessoaRepository.ObterTodos();
        public async Task Excluir(Guid Id)
        {
            var pessoa = _pessoaRepository.ObterPorId(Id).Result;
            if (!await PessoaExistente(pessoa)) return;

            pessoa.Ativo = false;           

            await _pessoaRepository.SalvarAlteracoes(pessoa);
        }

        public Task<Pessoa> ObterPorId(Pessoa pessoa) => _pessoaRepository.ObterPorId(pessoa.Id);

        public Task<Pessoa> ObterPorId(Guid id) => _pessoaRepository.ObterPorId(id);

        Task<List<Pessoa>> IPessoaRepository.ObterPessoaPorNome(string nome) => _pessoaRepository.ObterPessoaPorNome(nome);

        public Task<IEnumerable<Pessoa>> Buscar(Expression<Func<Pessoa, bool>> predicate)=>_pessoaRepository.Buscar(predicate);

        public void Dispose()
        {
            _pessoaRepository?.Dispose();
        }

    }
}
