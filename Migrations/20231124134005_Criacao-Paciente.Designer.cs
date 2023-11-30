﻿// <auto-generated />
using System;
using LaboratorioExame.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LaboratorioExame.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231124134005_Criacao-Paciente")]
    partial class CriacaoPaciente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LaboratorioExame.Models.Cargo", b =>
                {
                    b.Property<int>("CargoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CargoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CargoId"), 1L, 1);

                    b.Property<string>("CargoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CargoNome");

                    b.HasKey("CargoId");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("LaboratorioExame.Models.Cidade", b =>
                {
                    b.Property<int>("CidadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CidadeId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CidadeId"), 1L, 1);

                    b.Property<string>("CidadeNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CidadeNome");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.HasKey("CidadeId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("LaboratorioExame.Models.Estado", b =>
                {
                    b.Property<int>("EstadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EstadoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadoId"), 1L, 1);

                    b.Property<string>("EstadoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EstadoNome");

                    b.HasKey("EstadoId");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("LaboratorioExame.Models.Exame", b =>
                {
                    b.Property<int>("ExameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ExameId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExameId"), 1L, 1);

                    b.Property<string>("ExameMaterial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExameMaterial");

                    b.Property<string>("ExameNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExameNome");

                    b.Property<string>("ExameObservacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExameObservacao");

                    b.HasKey("ExameId");

                    b.ToTable("Exame");
                });

            modelBuilder.Entity("LaboratorioExame.Models.Paciente", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PacienteId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PacienteId"), 1L, 1);

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<string>("PacienteAlergia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PacienteAlergia");

                    b.Property<double>("PacienteAltura")
                        .HasColumnType("float")
                        .HasColumnName("PacienteAltura");

                    b.Property<string>("PacienteCpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PacienteCpf");

                    b.Property<string>("PacienteEndereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PacienteEndereco");

                    b.Property<string>("PacienteIdade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PacienteIdade");

                    b.Property<string>("PacienteNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PacienteNome");

                    b.Property<string>("PacienteNomeMae")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PacienteNomeMae");

                    b.Property<string>("PacienteObservacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PacienteObservacao");

                    b.Property<double>("PacientePeso")
                        .HasColumnType("float")
                        .HasColumnName("PacientePeso");

                    b.Property<string>("PacienteTelefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Pacientetelefone");

                    b.Property<string>("PacienteTipoSanguineo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PacienteTipoSanguineo");

                    b.Property<string>("Pacientesexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PacienteSexo");

                    b.HasKey("PacienteId");

                    b.HasIndex("CidadeId");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("LaboratorioExame.Models.Profissional", b =>
                {
                    b.Property<int>("ProfissionalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("profissionalId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfissionalId"), 1L, 1);

                    b.Property<int>("CargoId")
                        .HasColumnType("int");

                    b.Property<string>("ProfissionaNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("profissionalNome");

                    b.HasKey("ProfissionalId");

                    b.HasIndex("CargoId");

                    b.ToTable("Profissional");
                });

            modelBuilder.Entity("LaboratorioExame.Models.Resultado", b =>
                {
                    b.Property<int>("ResultadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ResultadoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResultadoId"), 1L, 1);

                    b.Property<DateTime>("DataRealizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataRealizacao");

                    b.Property<int>("ExameId")
                        .HasColumnType("int");

                    b.Property<string>("ObservacaoResultado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacaoResultado");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int>("ProfissionalId")
                        .HasColumnType("int");

                    b.Property<string>("ResultadoDescricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ResultadoDescricao");

                    b.HasKey("ResultadoId");

                    b.HasIndex("ExameId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("ProfissionalId");

                    b.ToTable("Resultado");
                });

            modelBuilder.Entity("LaboratorioExame.Models.Cidade", b =>
                {
                    b.HasOne("LaboratorioExame.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("LaboratorioExame.Models.Paciente", b =>
                {
                    b.HasOne("LaboratorioExame.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("LaboratorioExame.Models.Profissional", b =>
                {
                    b.HasOne("LaboratorioExame.Models.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("LaboratorioExame.Models.Resultado", b =>
                {
                    b.HasOne("LaboratorioExame.Models.Exame", "Exame")
                        .WithMany()
                        .HasForeignKey("ExameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LaboratorioExame.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LaboratorioExame.Models.Profissional", "Proissional")
                        .WithMany()
                        .HasForeignKey("ProfissionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exame");

                    b.Navigation("Paciente");

                    b.Navigation("Proissional");
                });
#pragma warning restore 612, 618
        }
    }
}
