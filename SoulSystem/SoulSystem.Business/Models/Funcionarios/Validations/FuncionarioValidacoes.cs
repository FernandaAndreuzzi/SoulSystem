using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Models.Funcionarios
{
    public class FuncionarioValidacoes : AbstractValidator<Funcionario>
    {
        public FuncionarioValidacoes() 
        {
            RuleFor(f => f.Funcao)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2,255)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength}.");

            RuleFor(f => f.DataDeContratacao)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.TipoContrato)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.Ativo)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");

        }
    }
}
