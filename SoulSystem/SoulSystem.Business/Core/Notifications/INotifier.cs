using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Core.Notifications
{
    public interface INotifier
    {
        bool TemNotificacao();
        List<Notification> ObterNotificacoes();
        void CriarNotificacao(Notification notification);
        bool RemoverNotificacoesDuplicadas();


    }
}
