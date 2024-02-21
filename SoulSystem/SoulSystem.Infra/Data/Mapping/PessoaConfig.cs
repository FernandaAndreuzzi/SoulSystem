﻿using SoulSystem.Business.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Infra.Data.Mapping
{
    public class PessoaConfig: EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfig()
        {
            HasKey(f => f.Id);

            Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(255);

            Property(f => f.Genero) 
                .IsRequired()
                .HasMaxLength(255);

            Property(f => f.Cpf) 
                .IsRequired()
                .HasMaxLength(255);

            Property(f => f.Rg)
                .IsRequired()
                .HasMaxLength(255);

            Property(f => f.DataDeNascimento);

            Property(f => f.Escolaridade)
                .IsRequired()
                .HasMaxLength(255);

            Property(f => f.Profissao)
                .HasMaxLength(255);

            Property(f => f.Ativo);

            ToTable("Pessoa");

           
        }
    }
}
