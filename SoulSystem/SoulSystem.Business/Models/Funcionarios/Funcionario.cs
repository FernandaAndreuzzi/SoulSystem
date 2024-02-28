using SoulSystem.Business.Core.Models;
using SoulSystem.Business.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Models
{
    public class Funcionario : Entity
    {
        public string Funcao { get; set; }
        public DateTime DataDeContratacao { get; set; }
        public  TipoContratacao TipoContrato { get; set; }
        public bool Ativo { get; set; }

        public Pessoa Pessoa { get; set;}


    } 
}
