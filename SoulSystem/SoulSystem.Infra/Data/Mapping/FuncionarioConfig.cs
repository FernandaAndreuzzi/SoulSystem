using SoulSystem.Business.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Infra.Data.Mapping
{
    public class FuncionarioConfig: EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfig() 
        {
            HasKey(f => f.Id);
            
            Property(f => f.Funcao)
                     .IsRequired()
                     .HasMaxLength(255);

            Property(f => f.DataDeContratacao);
            
            Property(f => f.TipoContrato).HasColumnType("int");

            Property(f => f.Ativo);

            ToTable("Funcionarios");
        }
    }
}
