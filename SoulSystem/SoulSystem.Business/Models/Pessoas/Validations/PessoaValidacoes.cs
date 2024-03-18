using FluentValidation;
using SoulSystem.Business.Core.Validations.Documentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Models.Pessoas
{
    public class PessoaValidacoes : AbstractValidator<Pessoa>
    {
        public PessoaValidacoes()
        {
            RuleFor(f => f.Nome)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 255)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength}.");

            RuleFor(f => f.Genero)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2,255);

            RuleFor(f => f.Cpf.Length).Equal(CpfValidacao.TamanhoCpf)
                .WithMessage("O campo Cpf precisa ter {ComparisonValue} caracteres e foi fornecido {PropertValue}.");

            RuleFor(f => CpfValidacao.Validar(f.Cpf)).Equal(true)
                    .WithMessage("O documento fornecido é inválido.");

            RuleFor(f => f.DataDeNascimento)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.Escolaridade)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2,255)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength}.");

            RuleFor(f => f.Profissao)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2,255)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength}.");

            RuleFor(f => f.Ativo)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");
                
        }
    }
}