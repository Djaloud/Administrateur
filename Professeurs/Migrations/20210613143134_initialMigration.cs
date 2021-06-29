using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Professeurs.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departements",
                columns: table => new
                {
                    departementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departements", x => x.departementId);
                });

            migrationBuilder.CreateTable(
                name: "professeurs",
                columns: table => new
                {
                    prof_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    departementId = table.Column<int>(type: "int", nullable: false),
                    Departement = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_professeurs", x => x.prof_id);
                    table.ForeignKey(
                        name: "FK_professeurs_departements_Departement",
                        column: x => x.Departement,
                        principalTable: "departements",
                        principalColumn: "departementId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "filieres",
                columns: table => new
                {
                    filiereId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Professeur = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filieres", x => x.filiereId);
                    table.ForeignKey(
                        name: "FK_filieres_professeurs_Professeur",
                        column: x => x.Professeur,
                        principalTable: "professeurs",
                        principalColumn: "prof_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "etudiants",
                columns: table => new
                {
                    apogee = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ddn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ldn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    natio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    annee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filiereId = table.Column<int>(type: "int", nullable: false),
                    picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sexe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etudiants", x => x.apogee);
                    table.ForeignKey(
                        name: "FK_etudiants_filieres_filiereId",
                        column: x => x.filiereId,
                        principalTable: "filieres",
                        principalColumn: "filiereId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "modules",
                columns: table => new
                {
                    moduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Professeur = table.Column<int>(type: "int", nullable: true),
                    filiereId = table.Column<int>(type: "int", nullable: false),
                    Filiere = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modules", x => x.moduleId);
                    table.ForeignKey(
                        name: "FK_modules_filieres_Filiere",
                        column: x => x.Filiere,
                        principalTable: "filieres",
                        principalColumn: "filiereId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_modules_professeurs_Professeur",
                        column: x => x.Professeur,
                        principalTable: "professeurs",
                        principalColumn: "prof_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "notes",
                columns: table => new
                {
                    NoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    semestre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    note = table.Column<int>(type: "int", nullable: false),
                    filiereId = table.Column<int>(type: "int", nullable: false),
                    Filiere = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notes", x => x.NoteId);
                    table.ForeignKey(
                        name: "FK_notes_filieres_Filiere",
                        column: x => x.Filiere,
                        principalTable: "filieres",
                        principalColumn: "filiereId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_etudiants_filiereId",
                table: "etudiants",
                column: "filiereId");

            migrationBuilder.CreateIndex(
                name: "IX_filieres_Professeur",
                table: "filieres",
                column: "Professeur");

            migrationBuilder.CreateIndex(
                name: "IX_modules_Filiere",
                table: "modules",
                column: "Filiere");

            migrationBuilder.CreateIndex(
                name: "IX_modules_Professeur",
                table: "modules",
                column: "Professeur");

            migrationBuilder.CreateIndex(
                name: "IX_notes_Filiere",
                table: "notes",
                column: "Filiere");

            migrationBuilder.CreateIndex(
                name: "IX_professeurs_Departement",
                table: "professeurs",
                column: "Departement");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "etudiants");

            migrationBuilder.DropTable(
                name: "modules");

            migrationBuilder.DropTable(
                name: "notes");

            migrationBuilder.DropTable(
                name: "filieres");

            migrationBuilder.DropTable(
                name: "professeurs");

            migrationBuilder.DropTable(
                name: "departements");
        }
    }
}
