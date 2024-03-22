using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SoulSystem.Business.Core.Notifications.Notifier;

namespace SoulSystem.Business.Core.Notifications
{
    public class Notifier : INotifier
    {
        private List<Notification> _notificacoes;

        public Notifier()
        {
            _notificacoes = new List<Notification>();
        }

        public void CriarNotificacao(Notification notification)
        {
            _notificacoes.Add(notification);
        }

        public List<Notification> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public bool RemoverNotificacoesDuplicadas()
        {
            throw new System.NotImplementedException();
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}
