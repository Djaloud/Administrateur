using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Professeurs.Migrations
{
    public partial class first_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_etudiants_filieres_filiereId",
                table: "etudiants");

            migrationBuilder.DropForeignKey(
                name: "FK_professeurs_departements_Departement",
                table: "professeurs");

            migrationBuilder.RenameColumn(
                name: "prenom",
                table: "professeurs",
                newName: "tel");

            migrationBuilder.RenameColumn(
                name: "nom",
                table: "professeurs",
                newName: "prenom_prof");

            migrationBuilder.RenameColumn(
                name: "Departement",
                table: "professeurs",
                newName: "Professeurid_professeur");

            migrationBuilder.RenameColumn(
                name: "prof_id",
                table: "professeurs",
                newName: "id_professeur");

            migrationBuilder.RenameIndex(
                name: "IX_professeurs_Departement",
                table: "professeurs",
                newName: "IX_professeurs_Professeurid_professeur");

            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "etudiants",
                newName: "ville_diplome");

            migrationBuilder.RenameColumn(
                name: "firstname",
                table: "etudiants",
                newName: "type_bac");

            migrationBuilder.RenameColumn(
                name: "cne",
                table: "etudiants",
                newName: "tel");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "etudiants",
                newName: "prenom");

            migrationBuilder.AlterColumn<string>(
                name: "departementId",
                table: "professeurs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "adresse",
                table: "professeurs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nom_prof",
                table: "professeurs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "filiereId",
                table: "etudiants",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ddn",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "Etudiantapogee",
                table: "etudiants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "academie",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "adresse",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "annee_bac",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "code_promo",
                table: "etudiants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "delegation",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "diplome",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ecole",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "father_job",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "father_name",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "filiere",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firstname_ar",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firstname_fr",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastname_ar",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastname_fr",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lycee",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "massar",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mention_bac",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mother_job",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mother_name",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nom",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "parents_adress",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "parents_phone",
                table: "etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "validated",
                table: "etudiants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_etudiants_Etudiantapogee",
                table: "etudiants",
                column: "Etudiantapogee");

            migrationBuilder.AddForeignKey(
                name: "FK_etudiants_etudiants_Etudiantapogee",
                table: "etudiants",
                column: "Etudiantapogee",
                principalTable: "etudiants",
                principalColumn: "apogee",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_etudiants_filieres_filiereId",
                table: "etudiants",
                column: "filiereId",
                principalTable: "filieres",
                principalColumn: "filiereId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_professeurs_professeurs_Professeurid_professeur",
                table: "professeurs",
                column: "Professeurid_professeur",
                principalTable: "professeurs",
                principalColumn: "id_professeur",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_etudiants_etudiants_Etudiantapogee",
                table: "etudiants");

            migrationBuilder.DropForeignKey(
                name: "FK_etudiants_filieres_filiereId",
                table: "etudiants");

            migrationBuilder.DropForeignKey(
                name: "FK_professeurs_professeurs_Professeurid_professeur",
                table: "professeurs");

            migrationBuilder.DropIndex(
                name: "IX_etudiants_Etudiantapogee",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "adresse",
                table: "professeurs");

            migrationBuilder.DropColumn(
                name: "nom_prof",
                table: "professeurs");

            migrationBuilder.DropColumn(
                name: "Etudiantapogee",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "academie",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "adresse",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "annee_bac",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "code_promo",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "delegation",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "diplome",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "ecole",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "father_job",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "father_name",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "filiere",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "firstname_ar",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "firstname_fr",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "lastname_ar",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "lastname_fr",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "lycee",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "massar",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "mention_bac",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "mother_job",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "mother_name",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "nom",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "parents_adress",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "parents_phone",
                table: "etudiants");

            migrationBuilder.DropColumn(
                name: "validated",
                table: "etudiants");

            migrationBuilder.RenameColumn(
                name: "tel",
                table: "professeurs",
                newName: "prenom");

            migrationBuilder.RenameColumn(
                name: "prenom_prof",
                table: "professeurs",
                newName: "nom");

            migrationBuilder.RenameColumn(
                name: "Professeurid_professeur",
                table: "professeurs",
                newName: "Departement");

            migrationBuilder.RenameColumn(
                name: "id_professeur",
                table: "professeurs",
                newName: "prof_id");

            migrationBuilder.RenameIndex(
                name: "IX_professeurs_Professeurid_professeur",
                table: "professeurs",
                newName: "IX_professeurs_Departement");

            migrationBuilder.RenameColumn(
                name: "ville_diplome",
                table: "etudiants",
                newName: "lastname");

            migrationBuilder.RenameColumn(
                name: "type_bac",
                table: "etudiants",
                newName: "firstname");

            migrationBuilder.RenameColumn(
                name: "tel",
                table: "etudiants",
                newName: "cne");

            migrationBuilder.RenameColumn(
                name: "prenom",
                table: "etudiants",
                newName: "address");

            migrationBuilder.AlterColumn<int>(
                name: "departementId",
                table: "professeurs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "filiereId",
                table: "etudiants",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ddn",
                table: "etudiants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_etudiants_filieres_filiereId",
                table: "etudiants",
                column: "filiereId",
                principalTable: "filieres",
                principalColumn: "filiereId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_professeurs_departements_Departement",
                table: "professeurs",
                column: "Departement",
                principalTable: "departements",
                principalColumn: "departementId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
