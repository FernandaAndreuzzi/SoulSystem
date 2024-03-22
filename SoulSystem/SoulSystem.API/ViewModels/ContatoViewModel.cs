using SoulSystem.Business.Models;
using System.ComponentModel.DataAnnotations;

namespace SoulSystem.API.ViewModels
{
    public class ContatoViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 8)]
        public long TelefoneFixo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public long TelefoneCelular { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public long ContatoDeEmergencia { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 2)]
        public string NomeContatoDeEmergencia { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 2)]
        public string RelacaoComPessoaContatoDeEmergencia { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
