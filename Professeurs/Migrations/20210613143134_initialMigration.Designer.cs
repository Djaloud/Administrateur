// <auto-generated />
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
    [Migration("20210613143134_initialMigration")]
    partial class initialMigration
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

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("annee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ddn")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("filiereId")
                        .HasColumnType("int");

                    b.Property<string>("firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ldn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("natio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sexe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("apogee");

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
                    b.Property<int>("prof_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Departement")
                        .HasColumnType("int");

                    b.Property<int>("departementId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("prof_id");

                    b.HasIndex("Departement");

                    b.ToTable("professeurs");
                });

            modelBuilder.Entity("Professeurs.Models.Etudiant", b =>
                {
                    b.HasOne("Professeurs.Models.Filiere", "filiere")
                        .WithMany("etudiants")
                        .HasForeignKey("filiereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("filiere");
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
                    b.HasOne("Professeurs.Models.Departement", "departement")
                        .WithMany()
                        .HasForeignKey("Departement");

                    b.Navigation("departement");
                });

            modelBuilder.Entity("Professeurs.Models.Filiere", b =>
                {
                    b.Navigation("etudiants");

                    b.Navigation("modules");
                });
#pragma warning restore 612, 618
        }
    }
}
