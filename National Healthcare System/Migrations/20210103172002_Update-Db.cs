using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace National_Healthcare_System.Migrations
{
    public partial class UpdateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultation_Doctor_Doctor_Id1",
                table: "Consultation");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Schedule_Doctor_Doctor_Id1",
                table: "Doctor_Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_Schedule_Doctor_Id1",
                table: "Doctor_Schedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_Consultation_Doctor_Id1",
                table: "Consultation");

            migrationBuilder.DropColumn(
                name: "Doctor_Id1",
                table: "Doctor_Schedule");

            migrationBuilder.DropColumn(
                name: "Doctor_Id1",
                table: "Consultation");

            migrationBuilder.AddColumn<int>(
                name: "Doctorid",
                table: "Doctor_Schedule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Doctor",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Doctorid",
                table: "Consultation",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Schedule_Doctorid",
                table: "Doctor_Schedule",
                column: "Doctorid");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Doctorid",
                table: "Consultation",
                column: "Doctorid");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultation_Doctor_Doctorid",
                table: "Consultation",
                column: "Doctorid",
                principalTable: "Doctor",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Schedule_Doctor_Doctorid",
                table: "Doctor_Schedule",
                column: "Doctorid",
                principalTable: "Doctor",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultation_Doctor_Doctorid",
                table: "Consultation");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Schedule_Doctor_Doctorid",
                table: "Doctor_Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_Schedule_Doctorid",
                table: "Doctor_Schedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_Consultation_Doctorid",
                table: "Consultation");

            migrationBuilder.DropColumn(
                name: "Doctorid",
                table: "Doctor_Schedule");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Doctorid",
                table: "Consultation");

            migrationBuilder.AddColumn<Guid>(
                name: "Doctor_Id1",
                table: "Doctor_Schedule",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Doctor_Id1",
                table: "Consultation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor",
                column: "Doctor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Schedule_Doctor_Id1",
                table: "Doctor_Schedule",
                column: "Doctor_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Doctor_Id1",
                table: "Consultation",
                column: "Doctor_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultation_Doctor_Doctor_Id1",
                table: "Consultation",
                column: "Doctor_Id1",
                principalTable: "Doctor",
                principalColumn: "Doctor_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Schedule_Doctor_Doctor_Id1",
                table: "Doctor_Schedule",
                column: "Doctor_Id1",
                principalTable: "Doctor",
                principalColumn: "Doctor_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
