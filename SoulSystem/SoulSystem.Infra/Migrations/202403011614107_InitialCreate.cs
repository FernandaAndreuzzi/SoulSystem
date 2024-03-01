namespace SoulSystem.Infra.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EncaminhamentoMedico = c.Boolean(nullable: false),
                        NomeDoMedicoResponsavel = c.String(maxLength: 255),
                        QueixaPrincipal = c.String(nullable: false, maxLength: 255),
                        PlanoDeSaude = c.String(nullable: false, maxLength: 20),
                        NumeroCarteiraPlanoDeSaude = c.Long(nullable: false),
                        CriadoPor = c.Guid(nullable: false),
                        CriadoEm = c.DateTime(nullable: false),
                        AlteradoPor = c.Guid(nullable: false),
                        AlteradoEm = c.DateTime(nullable: false),
                        Pessoa_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id)
                .Index(t => t.Pessoa_Id);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 255),
                        Genero = c.String(nullable: false, maxLength: 255),
                        Cpf = c.String(nullable: false, maxLength: 255,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "IX_Cpf",
                                    new AnnotationValues(oldValue: null, newValue: "IndexAnnotation: { IsUnique: True }")
                                },
                            }),
                        Rg = c.String(nullable: false, maxLength: 255,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "IX_Rg",
                                    new AnnotationValues(oldValue: null, newValue: "IndexAnnotation: { IsUnique: True }")
                                },
                            }),
                        DataDeNascimento = c.DateTime(nullable: false),
                        Escolaridade = c.String(nullable: false, maxLength: 255),
                        Profissao = c.String(maxLength: 255),
                        Ativo = c.Boolean(nullable: false),
                        CriadoPor = c.Guid(nullable: false),
                        CriadoEm = c.DateTime(nullable: false),
                        AlteradoPor = c.Guid(nullable: false),
                        AlteradoEm = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contato",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TelefoneFixo = c.Long(nullable: false),
                        TelefoneCelular = c.Long(nullable: false),
                        ContatoDeEmergencia = c.Long(nullable: false),
                        NomeContatoDeEmergencia = c.String(nullable: false, maxLength: 255),
                        RelacaoComPessoaContatoDeEmergencia = c.String(nullable: false, maxLength: 255),
                        CriadoPor = c.Guid(nullable: false),
                        CriadoEm = c.DateTime(nullable: false),
                        AlteradoPor = c.Guid(nullable: false),
                        AlteradoEm = c.DateTime(nullable: false),
                        Pessoa_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id)
                .Index(t => t.Pessoa_Id);
            
            CreateTable(
                "dbo.Enderecos",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Logradouro = c.String(nullable: false, maxLength: 200),
                        Numero = c.String(nullable: false, maxLength: 50),
                        Complemento = c.String(maxLength: 250),
                        Cep = c.String(nullable: false, maxLength: 8),
                        Bairro = c.String(nullable: false, maxLength: 255),
                        Cidade = c.String(nullable: false, maxLength: 255),
                        tipoEstado = c.Long(nullable: false),
                        Pais = c.String(maxLength: 255),
                        CriadoPor = c.Guid(nullable: false),
                        CriadoEm = c.DateTime(nullable: false),
                        AlteradoPor = c.Guid(nullable: false),
                        AlteradoEm = c.DateTime(nullable: false),
                        Pessoa_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id)
                .Index(t => t.Pessoa_Id);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Funcao = c.String(nullable: false, maxLength: 255),
                        DataDeContratacao = c.DateTime(nullable: false),
                        TipoContrato = c.Long(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        CriadoPor = c.Guid(nullable: false),
                        CriadoEm = c.DateTime(nullable: false),
                        AlteradoPor = c.Guid(nullable: false),
                        AlteradoEm = c.DateTime(nullable: false),
                        Pessoa_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id)
                .Index(t => t.Pessoa_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Funcionarios", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Enderecos", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Contato", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Clientes", "Pessoa_Id", "dbo.Pessoa");
            DropIndex("dbo.Funcionarios", new[] { "Pessoa_Id" });
            DropIndex("dbo.Enderecos", new[] { "Pessoa_Id" });
            DropIndex("dbo.Contato", new[] { "Pessoa_Id" });
            DropIndex("dbo.Clientes", new[] { "Pessoa_Id" });
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Enderecos");
            DropTable("dbo.Contato");
            DropTable("dbo.Pessoa",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Cpf",
                        new Dictionary<string, object>
                        {
                            { "IX_Cpf", "IndexAnnotation: { IsUnique: True }" },
                        }
                    },
                    {
                        "Rg",
                        new Dictionary<string, object>
                        {
                            { "IX_Rg", "IndexAnnotation: { IsUnique: True }" },
                        }
                    },
                });
            DropTable("dbo.Clientes");
        }
    }
}
