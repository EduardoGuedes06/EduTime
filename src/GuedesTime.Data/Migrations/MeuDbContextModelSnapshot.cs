﻿// <auto-generated />
using System;
using GuedesTime.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GuedesTime.Data.Migrations
{
    [DbContext(typeof(MeuDbContext))]
    partial class MeuDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("GuedesTime.Domain.Models.Atividades", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<Guid>("ProfessorId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Atividades", (string)null);
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.ConfiguracoesGenericas", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("NomeConfiguracao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ConfiguracoesGenericas", (string)null);
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Disciplina", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("int");

                    b.Property<Guid?>("InstituicaoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("InstituicaoId");

                    b.ToTable("Disciplinas", (string)null);
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("FornecedorId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId")
                        .IsUnique();

                    b.ToTable("Enderecos", (string)null);
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Feriado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("InstituicaoId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("InstituicaoId1")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Recorrente")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("InstituicaoId");

                    b.HasIndex("InstituicaoId1");

                    b.ToTable("Feriados", (string)null);
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Fornecedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("TipoFornecedor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores", (string)null);
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.HistoricoExportacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataExportacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NomeArquivo")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Observacoes")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("UsuarioResponsavel")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("HistoricoExportacao", (string)null);
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Horario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Fim")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("InstituicaoId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("InstituicaoId");

                    b.ToTable("Horarios", (string)null);
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Instituicao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("Instituicoes", (string)null);
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Log", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Acao")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Detalhes")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Logs", (string)null);
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.PlanejamentoDeAula", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("DisciplinaId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("HistoricoExportacaoId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("HorarioId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("InstituicaoId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("InstituicaoId1")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ProfessorId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("SalaId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("TurmaId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("DisciplinaId");

                    b.HasIndex("HistoricoExportacaoId");

                    b.HasIndex("HorarioId");

                    b.HasIndex("InstituicaoId");

                    b.HasIndex("InstituicaoId1");

                    b.HasIndex("ProfessorId");

                    b.HasIndex("SalaId");

                    b.HasIndex("TurmaId");

                    b.ToTable("PlanejamentoDeAulas", (string)null);
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<Guid>("FornecedorId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Produtos", (string)null);
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Professor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(100)");

                    b.Property<Guid?>("InstituicaoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("InstituicaoId");

                    b.ToTable("Professores", (string)null);
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Restricao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("ProfessorId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Restricoes", (string)null);
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Sala", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Capacidade")
                        .HasColumnType("int");

                    b.Property<Guid?>("InstituicaoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("InstituicaoId");

                    b.ToTable("Salas", (string)null);
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Tarefas", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataLimite")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("ProfessorId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Tarefas", (string)null);
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Turma", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<Guid?>("InstituicaoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("InstituicaoId");

                    b.ToTable("Turmas", (string)null);
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Atividades", b =>
                {
                    b.HasOne("GuedesTime.Domain.Models.Professor", "Professor")
                        .WithMany("Atividades")
                        .HasForeignKey("ProfessorId")
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Disciplina", b =>
                {
                    b.HasOne("GuedesTime.Domain.Models.Instituicao", null)
                        .WithMany("Disciplinas")
                        .HasForeignKey("InstituicaoId");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Endereco", b =>
                {
                    b.HasOne("GuedesTime.Domain.Models.Fornecedor", "Fornecedor")
                        .WithOne("Endereco")
                        .HasForeignKey("GuedesTime.Domain.Models.Endereco", "FornecedorId")
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Feriado", b =>
                {
                    b.HasOne("GuedesTime.Domain.Models.Instituicao", null)
                        .WithMany("Feriados")
                        .HasForeignKey("InstituicaoId")
                        .IsRequired();

                    b.HasOne("GuedesTime.Domain.Models.Instituicao", "Instituicao")
                        .WithMany()
                        .HasForeignKey("InstituicaoId1")
                        .IsRequired();

                    b.Navigation("Instituicao");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Horario", b =>
                {
                    b.HasOne("GuedesTime.Domain.Models.Instituicao", null)
                        .WithMany("Horarios")
                        .HasForeignKey("InstituicaoId");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.PlanejamentoDeAula", b =>
                {
                    b.HasOne("GuedesTime.Domain.Models.Disciplina", "Disciplina")
                        .WithMany("PlanejamentosDeAula")
                        .HasForeignKey("DisciplinaId")
                        .IsRequired();

                    b.HasOne("GuedesTime.Domain.Models.HistoricoExportacao", "HistoricoExportacao")
                        .WithMany("PlanejamentosDeAula")
                        .HasForeignKey("HistoricoExportacaoId")
                        .IsRequired();

                    b.HasOne("GuedesTime.Domain.Models.Horario", "Horario")
                        .WithMany("PlanejamentosDeAula")
                        .HasForeignKey("HorarioId")
                        .IsRequired();

                    b.HasOne("GuedesTime.Domain.Models.Instituicao", null)
                        .WithMany()
                        .HasForeignKey("InstituicaoId")
                        .IsRequired();

                    b.HasOne("GuedesTime.Domain.Models.Instituicao", "Instituicao")
                        .WithMany()
                        .HasForeignKey("InstituicaoId1")
                        .IsRequired();

                    b.HasOne("GuedesTime.Domain.Models.Professor", "Professor")
                        .WithMany("PlanejamentosDeAula")
                        .HasForeignKey("ProfessorId")
                        .IsRequired();

                    b.HasOne("GuedesTime.Domain.Models.Sala", "Sala")
                        .WithMany("PlanejamentosDeAula")
                        .HasForeignKey("SalaId")
                        .IsRequired();

                    b.HasOne("GuedesTime.Domain.Models.Turma", "Turma")
                        .WithMany("PlanejamentosDeAula")
                        .HasForeignKey("TurmaId")
                        .IsRequired();

                    b.Navigation("Disciplina");

                    b.Navigation("HistoricoExportacao");

                    b.Navigation("Horario");

                    b.Navigation("Instituicao");

                    b.Navigation("Professor");

                    b.Navigation("Sala");

                    b.Navigation("Turma");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Produto", b =>
                {
                    b.HasOne("GuedesTime.Domain.Models.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorId")
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Professor", b =>
                {
                    b.HasOne("GuedesTime.Domain.Models.Instituicao", null)
                        .WithMany("Professores")
                        .HasForeignKey("InstituicaoId");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Restricao", b =>
                {
                    b.HasOne("GuedesTime.Domain.Models.Professor", "Professor")
                        .WithMany("Restricoes")
                        .HasForeignKey("ProfessorId")
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Sala", b =>
                {
                    b.HasOne("GuedesTime.Domain.Models.Instituicao", null)
                        .WithMany("Salas")
                        .HasForeignKey("InstituicaoId");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Tarefas", b =>
                {
                    b.HasOne("GuedesTime.Domain.Models.Professor", "Professor")
                        .WithMany("Tarefas")
                        .HasForeignKey("ProfessorId")
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Turma", b =>
                {
                    b.HasOne("GuedesTime.Domain.Models.Instituicao", null)
                        .WithMany("Turmas")
                        .HasForeignKey("InstituicaoId");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Disciplina", b =>
                {
                    b.Navigation("PlanejamentosDeAula");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Fornecedor", b =>
                {
                    b.Navigation("Endereco")
                        .IsRequired();

                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.HistoricoExportacao", b =>
                {
                    b.Navigation("PlanejamentosDeAula");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Horario", b =>
                {
                    b.Navigation("PlanejamentosDeAula");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Instituicao", b =>
                {
                    b.Navigation("Disciplinas");

                    b.Navigation("Feriados");

                    b.Navigation("Horarios");

                    b.Navigation("Professores");

                    b.Navigation("Salas");

                    b.Navigation("Turmas");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Professor", b =>
                {
                    b.Navigation("Atividades");

                    b.Navigation("PlanejamentosDeAula");

                    b.Navigation("Restricoes");

                    b.Navigation("Tarefas");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Sala", b =>
                {
                    b.Navigation("PlanejamentosDeAula");
                });

            modelBuilder.Entity("GuedesTime.Domain.Models.Turma", b =>
                {
                    b.Navigation("PlanejamentosDeAula");
                });
#pragma warning restore 612, 618
        }
    }
}
