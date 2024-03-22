using SoulSystem.Business.Models;
using SoulSystem.Business.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace SoulSystem.API.Models
{
    public class FuncionarioViewModel

    {
        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        [StringLength(255, MinimumLength = 2)]
        public string Funcao { get; set; }
        
        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        public DateTime DataDeContratacao { get; set; }

        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        public TipoContratacao TipoContrato { get; set; }

        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        public bool Ativo { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
