using System.ComponentModel.DataAnnotations;

namespace SoulSystem.API.ViewModels
{
    public class EnderecoViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 2)]
        public string Logradouro { get; set; }
       
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 1)]
        public string Numero { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 1)]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 2)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public TipoEstado tipoEstado { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 2)]
        public string Pais { get; set; }
        public Pessoa Pessoa { get; set; }

    }
}
