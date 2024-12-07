﻿// <auto-generated />
using System;
using GestionPaieApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionPaieApi.Migrations
{
    [DbContext(typeof(Db_context))]
    [Migration("20241207224244_v0.10")]
    partial class v010
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestionPaieApi.Models.Employe", b =>
                {
                    b.Property<string>("NSS")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Adresse")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Categorie")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateRecrutement")
                        .HasColumnType("datetime2");

                    b.Property<string>("FonctionPrincipale")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LieuNaissance")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("NombreEnfants")
                        .HasColumnType("int");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("PrimeVariable")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Sexe")
                        .HasColumnType("int");

                    b.Property<int?>("SituationFamiliale")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<decimal?>("TauxIndemniteNuisance")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("NSS");

                    b.ToTable("Employes");
                });

            modelBuilder.Entity("GestionPaieApi.Models.EmployeResponsabilites", b =>
                {
                    b.Property<int>("EmployeResponsabilitesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeResponsabilitesId"));

                    b.Property<string>("EmployeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ResponsabiliteID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EmployeResponsabilitesId");

                    b.HasIndex("EmployeID");

                    b.HasIndex("ResponsabiliteID");

                    b.ToTable("EmployeResponsabilites");
                });

            modelBuilder.Entity("GestionPaieApi.Models.LettreAccompagnee", b =>
                {
                    b.Property<int>("DemandeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DemandeId"));

                    b.Property<string>("Commentaires")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("DateDemande")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Raison")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Statut")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TypeChangement")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DemandeId");

                    b.HasIndex("EmployeId");

                    b.ToTable("LettreAccompagnee");
                });

            modelBuilder.Entity("GestionPaieApi.Models.Pointage", b =>
                {
                    b.Property<string>("EmployeId")
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan?>("DebutApresMidi")
                        .HasColumnType("time");

                    b.Property<TimeSpan?>("DebutMatinee")
                        .HasColumnType("time");

                    b.Property<TimeSpan?>("DureeDePause")
                        .HasColumnType("time");

                    b.Property<TimeSpan?>("FinApresMidi")
                        .HasColumnType("time");

                    b.Property<TimeSpan?>("FinMatinee")
                        .HasColumnType("time");

                    b.Property<double?>("HeuresSupplementaires")
                        .HasColumnType("float");

                    b.HasKey("EmployeId", "Date");

                    b.ToTable("Pointage");
                });

            modelBuilder.Entity("GestionPaieApi.Models.ResponsabiliteAdministrative", b =>
                {
                    b.Property<string>("ResponsabiliteID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("NomResp")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ResponsabiliteID");

                    b.HasIndex("NomResp")
                        .IsUnique();

                    b.ToTable("ResponsabilitesAdministratives");
                });

            modelBuilder.Entity("GestionPaieApi.Models.EmployeResponsabilites", b =>
                {
                    b.HasOne("GestionPaieApi.Models.Employe", "Employe")
                        .WithMany("EmployeResponsabilites")
                        .HasForeignKey("EmployeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestionPaieApi.Models.ResponsabiliteAdministrative", "Responsabilite")
                        .WithMany("EmployeResponsabilites")
                        .HasForeignKey("ResponsabiliteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employe");

                    b.Navigation("Responsabilite");
                });

            modelBuilder.Entity("GestionPaieApi.Models.LettreAccompagnee", b =>
                {
                    b.HasOne("GestionPaieApi.Models.Employe", "Employe")
                        .WithMany("DemandesChangements")
                        .HasForeignKey("EmployeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employe");
                });

            modelBuilder.Entity("GestionPaieApi.Models.Pointage", b =>
                {
                    b.HasOne("GestionPaieApi.Models.Employe", "Employe")
                        .WithMany()
                        .HasForeignKey("EmployeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employe");
                });

            modelBuilder.Entity("GestionPaieApi.Models.Employe", b =>
                {
                    b.Navigation("DemandesChangements");

                    b.Navigation("EmployeResponsabilites");
                });

            modelBuilder.Entity("GestionPaieApi.Models.ResponsabiliteAdministrative", b =>
                {
                    b.Navigation("EmployeResponsabilites");
                });
#pragma warning restore 612, 618
        }
    }
}
