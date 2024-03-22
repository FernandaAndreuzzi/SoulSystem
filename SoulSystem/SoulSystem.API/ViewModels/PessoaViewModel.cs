using System.ComponentModel.DataAnnotations;

namespace SoulSystem.API.ViewModels
{
    public class PessoaViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 2)]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 2)]
        public string Genero { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, MinimumLength = 11)]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataDeNascimento { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 2)]
        public string Escolaridade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 2)]
        public string Profissao { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Ativo { get; set; }
    }
}
