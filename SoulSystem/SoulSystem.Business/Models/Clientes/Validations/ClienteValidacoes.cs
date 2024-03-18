using FluentValidation;

namespace SoulSystem.Business.Models.Clientes
{
    public class ClienteValidacoes : AbstractValidator<Cliente>
    {
        public ClienteValidacoes()
        {
            RuleFor(f => f.EncaminhamentoMedico)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.NomeDoMedicoResponsavel)
                .NotEmpty()
                .Length(255);
           
            RuleFor(f => f.QueixaPrincipal)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(255);

            RuleFor(f => f.PlanoDeSaude)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(255);

            RuleFor(f => f.NumeroCarteiraPlanoDeSaude)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");
               
        }
    }
}
