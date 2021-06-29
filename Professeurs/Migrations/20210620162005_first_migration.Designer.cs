﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Professeurs.Models;

namespace Professeurs.Migrations
{
    [DbContext(typeof(myDataContext))]
    [Migration("20210620162005_first_migration")]
    partial class first_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Professeurs.Models.Departement", b =>
                {
                    b.Property<int>("departementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("departementId");

                    b.ToTable("departements");
                });

            modelBuilder.Entity("Professeurs.Models.Etudiant", b =>
                {
                    b.Property<int>("apogee")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Etudiantapogee")
                        .HasColumnType("int");

                    b.Property<string>("academie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("annee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("annee_bac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("code_promo")
                        .HasColumnType("int");

                    b.Property<string>("ddn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("delegation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diplome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ecole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("father_job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("father_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filiere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("filiereId")
                        .HasColumnType("int");

                    b.Property<string>("firstname_ar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstname_fr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastname_ar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastname_fr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ldn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lycee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("massar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mention_bac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mother_job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mother_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("natio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parents_adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parents_phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sexe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type_bac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("validated")
                        .HasColumnType("int");

                    b.Property<string>("ville_diplome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("apogee");

                    b.HasIndex("Etudiantapogee");

                    b.HasIndex("filiereId");

                    b.ToTable("etudiants");
                });

            modelBuilder.Entity("Professeurs.Models.Filiere", b =>
                {
                    b.Property<int>("filiereId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Professeur")
                        .HasColumnType("int");

                    b.Property<string>("nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("filiereId");

                    b.HasIndex("Professeur");

                    b.ToTable("filieres");
                });

            modelBuilder.Entity("Professeurs.Models.Module", b =>
                {
                    b.Property<int>("moduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Filiere")
                        .HasColumnType("int");

                    b.Property<int?>("Professeur")
                        .HasColumnType("int");

                    b.Property<int>("filiereId")
                        .HasColumnType("int");

                    b.Property<string>("nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("moduleId");

                    b.HasIndex("Filiere");

                    b.HasIndex("Professeur");

                    b.ToTable("modules");
                });

            modelBuilder.Entity("Professeurs.Models.Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Filiere")
                        .HasColumnType("int");

                    b.Property<int>("filiereId")
                        .HasColumnType("int");

                    b.Property<int>("note")
                        .HasColumnType("int");

                    b.Property<string>("semestre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NoteId");

                    b.HasIndex("Filiere");

                    b.ToTable("notes");
                });

            modelBuilder.Entity("Professeurs.Models.Professeur", b =>
                {
                    b.Property<int>("id_professeur")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Professeurid_professeur")
                        .HasColumnType("int");

                    b.Property<string>("adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("departementId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom_prof")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenom_prof")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_professeur");

                    b.HasIndex("Professeurid_professeur");

                    b.ToTable("professeurs");
                });

            modelBuilder.Entity("Professeurs.Models.Etudiant", b =>
                {
                    b.HasOne("Professeurs.Models.Etudiant", null)
                        .WithMany("etudiant")
                        .HasForeignKey("Etudiantapogee");

                    b.HasOne("Professeurs.Models.Filiere", null)
                        .WithMany("etudiants")
                        .HasForeignKey("filiereId");
                });

            modelBuilder.Entity("Professeurs.Models.Filiere", b =>
                {
                    b.HasOne("Professeurs.Models.Professeur", "coordinateur")
                        .WithMany()
                        .HasForeignKey("Professeur");

                    b.Navigation("coordinateur");
                });

            modelBuilder.Entity("Professeurs.Models.Module", b =>
                {
                    b.HasOne("Professeurs.Models.Filiere", "filiere")
                        .WithMany("modules")
                        .HasForeignKey("Filiere");

                    b.HasOne("Professeurs.Models.Professeur", "responsable")
                        .WithMany()
                        .HasForeignKey("Professeur");

                    b.Navigation("filiere");

                    b.Navigation("responsable");
                });

            modelBuilder.Entity("Professeurs.Models.Note", b =>
                {
                    b.HasOne("Professeurs.Models.Filiere", "filiere")
                        .WithMany()
                        .HasForeignKey("Filiere");

                    b.Navigation("filiere");
                });

            modelBuilder.Entity("Professeurs.Models.Professeur", b =>
                {
                    b.HasOne("Professeurs.Models.Professeur", null)
                        .WithMany("professeur")
                        .HasForeignKey("Professeurid_professeur");
                });

            modelBuilder.Entity("Professeurs.Models.Etudiant", b =>
                {
                    b.Navigation("etudiant");
                });

            modelBuilder.Entity("Professeurs.Models.Filiere", b =>
                {
                    b.Navigation("etudiants");

                    b.Navigation("modules");
                });

            modelBuilder.Entity("Professeurs.Models.Professeur", b =>
                {
                    b.Navigation("professeur");
                });
#pragma warning restore 612, 618
        }
    }
}