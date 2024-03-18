using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace SoulSystem.Business.Models.Contatos
{
    public class ContatoValidacoes : AbstractValidator<Contato>
    {
        public ContatoValidacoes()
        {
            RuleFor(f => f.TelefoneFixo)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.TelefoneCelular)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.ContatoDeEmergencia) 
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");
            
            RuleFor(f => f.NomeContatoDeEmergencia)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2,255)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres.");


            RuleFor(f => f.RelacaoComPessoaContatoDeEmergencia)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2,255)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres.");


        }
    }
}
