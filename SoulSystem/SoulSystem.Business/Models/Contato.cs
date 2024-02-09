using SoulSystem.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Models
{
    public class Contato:Entity
    {
        public long TelefoneFixo { get; set; }
        public long TelefoneCelular { get; set; }
        public long ContatoDeEmergencia {  get; set; }
        public string NomeContatoDeEmergencia { get; set; }
        public string RelacaoComPessoaContatoDeEmergencia { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
