using SoulSystem.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Models
{
    public class Cliente : Entity
    {
        public bool EncaminhamentoMedico { get; set; }
        public string NomeDoMedicoResponsavel { get; set; }
        public string QueixaPrincipal { get; set; }
        public string PlanoDeSaude {  get; set; }
        public long NumeroCarteiraPlanoDeSaude { get; set; }
        public Pessoa Pessoa { get; set; }

    }
}
