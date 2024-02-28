using SoulSystem.Business.Core.Models;
using SoulSystem.Business.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Models
{
    public class Endereco:Entity
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public TipoEstado tipoEstado { get; set; }
        public string Pais { get; set; }
        public Pessoa Pessoa { get; set;}

    }
}
