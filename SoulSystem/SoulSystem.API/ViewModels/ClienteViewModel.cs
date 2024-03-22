using SoulSystem.Business.Models;
using System.ComponentModel.DataAnnotations;

namespace SoulSystem.API.ViewModels
{
    public class ClienteViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool EncaminhamentoMedico { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 2)]
        public string NomeDoMedicoResponsavel { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 2)]
        public string QueixaPrincipal { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 2)]
        public string PlanoDeSaude { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public long NumeroCarteiraPlanoDeSaude { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
