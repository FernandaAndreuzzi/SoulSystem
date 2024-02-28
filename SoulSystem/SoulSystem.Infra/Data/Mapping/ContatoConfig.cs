using SoulSystem.Business.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Infra.Data.Mapping
{
    public class ContatoConfig : EntityTypeConfiguration<Contato>
    {
        public ContatoConfig()
        {
            HasKey(f => f.Id);
            
            Property(f => f.TelefoneFixo);

            Property(f => f.TelefoneCelular)
                     .IsRequired();

            Property(f => f.ContatoDeEmergencia)
                     .IsRequired();

            Property(f => f.NomeContatoDeEmergencia)
                     .IsRequired()
                     .HasMaxLength(255);
           
            Property(f => f.RelacaoComPessoaContatoDeEmergencia)
                     .IsRequired()
                     .HasMaxLength(255);
            
            HasRequired(p => p.Pessoa);

            ToTable("Contato");


        }
    } 
}
