using SoulSystem.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoulSystem.Business.Models
{
    public class Pessoa:Entity 
    {
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Cpf { get; set;}
        public string Rg {  get; set;}
        public DateTime DataDeNascimento { get; set;}
        public string Escolaridade { get; set;}
        public string Profissao { get; set;}
        public bool Ativo { get; set; }


    }
}
