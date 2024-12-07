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
    [Migration("20241205090049_v0.3")]
    partial class v03
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

                    b.Property<string>("ResponsabilitePrincipalID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmployeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("EmployeNSS")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ResponsabiliteID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeID");

                    b.HasIndex("EmployeNSS")
                        .IsUnique()
                        .HasFilter("[EmployeNSS] IS NOT NULL");

                    b.HasIndex("ResponsabiliteID");

                    b.ToTable("EmployeResponsabilites");
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

                    b.HasOne("GestionPaieApi.Models.Employe", null)
                        .WithOne("ResponsabilitePrincipal")
                        .HasForeignKey("GestionPaieApi.Models.EmployeResponsabilites", "EmployeNSS");

                    b.HasOne("GestionPaieApi.Models.ResponsabiliteAdministrative", "Responsabilite")
                        .WithMany("EmployeResponsabilites")
                        .HasForeignKey("ResponsabiliteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employe");

                    b.Navigation("Responsabilite");
                });

            modelBuilder.Entity("GestionPaieApi.Models.Employe", b =>
                {
                    b.Navigation("EmployeResponsabilites");

                    b.Navigation("ResponsabilitePrincipal")
                        .IsRequired();
                });

            modelBuilder.Entity("GestionPaieApi.Models.ResponsabiliteAdministrative", b =>
                {
                    b.Navigation("EmployeResponsabilites");
                });
#pragma warning restore 612, 618
        }
    }
}
