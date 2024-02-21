using SoulSystem.Business.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Infra.Data.Mapping
{
    public class ClienteConfig: EntityTypeConfiguration<Cliente>    
    {
        public ClienteConfig()
        {
            HasKey(f => f.Id);

            Property(f => f.EncaminhamentoMedico);

            Property(f => f.NomeDoMedicoResponsavel)
                    .HasMaxLength(255);

            Property(f => f.QueixaPrincipal)
                     .IsRequired()
                     .HasMaxLength(255);

            Property(f => f.PlanoDeSaude)
                .IsRequired()
                .HasMaxLength(20);

            Property(f => f.NumeroCarteiraPlanoDeSaude)
                    .IsRequired();

            ToTable("Clientes");
        }
    }
}
