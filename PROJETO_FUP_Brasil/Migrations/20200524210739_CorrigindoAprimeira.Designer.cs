﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROJETO_FUP_Brasil.Data;

namespace PROJETO_FUP_Brasil.Migrations
{
    [DbContext(typeof(PROJETO_FUP_BrasilContext))]
    [Migration("20200524210739_CorrigindoAprimeira")]
    partial class CorrigindoAprimeira
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ForeignKey_Email.Email", b =>
                {
                    b.Property<int>("Id_Email")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("ChefiaId")
                        .HasColumnType("int");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<string>("_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Email");

                    b.HasIndex("AlunoId")
                        .IsUnique();

                    b.HasIndex("ChefiaId")
                        .IsUnique();

                    b.HasIndex("FuncionarioId")
                        .IsUnique();

                    b.ToTable("Email");
                });

            modelBuilder.Entity("PROJETO_FUP_Brasil.Models.Chefia", b =>
                {
                    b.Property<int>("ChefiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<string>("NomeChefia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Setor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChefiaId");

                    b.ToTable("Chefia");
                });

            modelBuilder.Entity("PROJETO_FUP_Brasil.Models.Cursos", b =>
                {
                    b.Property<int>("Id_Curso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeCurso")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("ProfessorCurso")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<decimal>("ValorCurso")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id_Curso");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("PROJETO_FUP_Brasil.Models.FinanceiroViewModel", b =>
                {
                    b.Property<int>("FinanceiroViewModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("FinanceiroViewModelId");

                    b.ToTable("Financeiro");
                });

            modelBuilder.Entity("PROJETO_FUP_Brasil.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<DateTime>("DataContratacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataDemissao")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Datanascimento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FinanceiroViewModelId")
                        .HasColumnType("int");

                    b.Property<int?>("Funcionario")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<string>("NomeFuncionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<decimal>("SalarioFuncionario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FuncionarioId");

                    b.HasIndex("FinanceiroViewModelId");

                    b.HasIndex("Funcionario");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("Remake_FUP.Models.Aluno", b =>
                {
                    b.Property<int>("Id_Matricula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<int>("CursosID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInicioCurso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataTerminoCurso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Datanascimento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FinanceiroViewModelId")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<decimal>("Mensalidade")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.HasKey("Id_Matricula");

                    b.HasIndex("CursosID");

                    b.HasIndex("FinanceiroViewModelId");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("Remake_FUP.Models.Telefone", b =>
                {
                    b.Property<int>("TelefoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("ChefiaId")
                        .HasColumnType("int");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<int?>("Telefone")
                        .HasColumnType("int");

                    b.Property<string>("_Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TelefoneId");

                    b.HasIndex("AlunoId")
                        .IsUnique();

                    b.HasIndex("FuncionarioId")
                        .IsUnique();

                    b.HasIndex("Telefone")
                        .IsUnique()
                        .HasFilter("[Telefone] IS NOT NULL");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("ForeignKey_Email.Email", b =>
                {
                    b.HasOne("Remake_FUP.Models.Aluno", "Aluno")
                        .WithOne("Email")
                        .HasForeignKey("ForeignKey_Email.Email", "AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PROJETO_FUP_Brasil.Models.Chefia", "Chefia")
                        .WithOne("Email")
                        .HasForeignKey("ForeignKey_Email.Email", "ChefiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PROJETO_FUP_Brasil.Models.Funcionario", "Funcionario")
                        .WithOne("Email")
                        .HasForeignKey("ForeignKey_Email.Email", "FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PROJETO_FUP_Brasil.Models.Funcionario", b =>
                {
                    b.HasOne("PROJETO_FUP_Brasil.Models.FinanceiroViewModel", "Financeiro")
                        .WithMany("Funcionarios")
                        .HasForeignKey("FinanceiroViewModelId");

                    b.HasOne("PROJETO_FUP_Brasil.Models.Chefia", "Chefia")
                        .WithMany("Funcionarios")
                        .HasForeignKey("Funcionario");
                });

            modelBuilder.Entity("Remake_FUP.Models.Aluno", b =>
                {
                    b.HasOne("PROJETO_FUP_Brasil.Models.Cursos", "Cursos")
                        .WithMany("Aluno")
                        .HasForeignKey("CursosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PROJETO_FUP_Brasil.Models.FinanceiroViewModel", null)
                        .WithMany("Alunos")
                        .HasForeignKey("FinanceiroViewModelId");
                });

            modelBuilder.Entity("Remake_FUP.Models.Telefone", b =>
                {
                    b.HasOne("Remake_FUP.Models.Aluno", "Aluno")
                        .WithOne("Telefone")
                        .HasForeignKey("Remake_FUP.Models.Telefone", "AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PROJETO_FUP_Brasil.Models.Funcionario", "Funcionario")
                        .WithOne("Telefone")
                        .HasForeignKey("Remake_FUP.Models.Telefone", "FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PROJETO_FUP_Brasil.Models.Chefia", "Chefia")
                        .WithOne("Telefone")
                        .HasForeignKey("Remake_FUP.Models.Telefone", "Telefone");
                });
#pragma warning restore 612, 618
        }
    }
}
