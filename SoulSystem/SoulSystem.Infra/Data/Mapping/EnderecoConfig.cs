using SoulSystem.Business.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoulSystem.Infra.Data.Mapping
{
    public class EnderecoConfig: EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(p => p.Id);

            Property(c => c.Logradouro)
                .IsRequired()
                .HasMaxLength(200);

            Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Cep)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength();

            Property(c => c.Complemento)
                .HasMaxLength(250);

            Property(c => c.Bairro)
                .IsRequired();

            Property(c => c.Cidade)
                .IsRequired();

            Property(f => f.tipoEstado).HasColumnType("int8");

            HasRequired(p => p.Pessoa);

            ToTable("Enderecos");
        }
    }
}

