using SoulSystem.Business.Models;
using SoulSystem.Business.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace SoulSystem.API.Models
{
    public class FuncionarioViewModel

    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 2)]
        public string Funcao { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataDeContratacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public TipoContratacao TipoContrato { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Ativo { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
