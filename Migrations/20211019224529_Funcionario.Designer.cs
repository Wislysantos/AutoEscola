﻿// <auto-generated />
using System;
using AutoEscola.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoEscola.Migrations
{
    [DbContext(typeof(AutoEscolaContext))]
    [Migration("20211019224529_Funcionario")]
    partial class Funcionario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoEscola.Pages.Aluno.Aluno", b =>
                {
                    b.Property<int>("AlunoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Celular")
                        .HasColumnType("bigint");

                    b.Property<long>("Cep")
                        .HasColumnType("bigint");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Cpf")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataAluno")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeAluno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Telefone")
                        .HasColumnType("bigint");

                    b.HasKey("AlunoID");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("AutoEscola.Pages.Funcionario.Funcionario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Celular")
                        .HasColumnType("bigint");

                    b.Property<long>("Cep")
                        .HasColumnType("bigint");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Cpf")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Funcao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MyProperty")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Telefone")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.ToTable("Funcionario");
                });
#pragma warning restore 612, 618
        }
    }
}
