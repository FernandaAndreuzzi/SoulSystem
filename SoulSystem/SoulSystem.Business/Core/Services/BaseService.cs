using FluentValidation;
using FluentValidation.Results;
using SoulSystem.Business.Core.Models;
using SoulSystem.Business.Core.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Core.Services
{
    public abstract class BaseService
    {
        private readonly INotifier _notificador;

        protected BaseService(INotifier notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            _notificador.CriarNotificacao(new Notification(mensagem));
        }

        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = (validacao.Validate(entidade));

            if (validator.IsValid) return true;

            Notificar(validator);

            return false;

        }
    }
}
