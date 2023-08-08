using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassroomHub.Data.Migrations
{
    public partial class atualzan_tabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Students_StudentId",
                table: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_Activities_StudentId",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Activities");

            migrationBuilder.AddColumn<Guid>(
                name: "ClassId",
                table: "Modules",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "StudentId",
                table: "Delivery",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modules_ClassId",
                table: "Modules",
                column: "ClassId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_StudentId",
                table: "Delivery",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_Students_StudentId",
                table: "Delivery",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Classes_ClassId",
                table: "Modules",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_Students_StudentId",
                table: "Delivery");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Classes_ClassId",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Modules_ClassId",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Delivery_StudentId",
                table: "Delivery");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Delivery");

            migrationBuilder.AddColumn<Guid>(
                name: "StudentId",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Activities_StudentId",
                table: "Activities",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Students_StudentId",
                table: "Activities",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
