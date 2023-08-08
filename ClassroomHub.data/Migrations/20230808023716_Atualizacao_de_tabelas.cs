using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassroomHub.Data.Migrations
{
    public partial class Atualizacao_de_tabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_Activities_ActivityId",
                table: "Delivery");

            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_Students_StudentId",
                table: "Delivery");

            migrationBuilder.DropIndex(
                name: "IX_Grade_DeliveryId",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Delivery");

            migrationBuilder.DropColumn(
                name: "SubmissionDate",
                table: "Delivery");

            migrationBuilder.AddColumn<string>(
                name: "Especializacao",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentId",
                table: "Delivery",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveyDate",
                table: "Delivery",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "Delivery",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Resolution",
                table: "Delivery",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Grade_DeliveryId",
                table: "Grade",
                column: "DeliveryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_Activities_ActivityId",
                table: "Delivery",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_Students_StudentId",
                table: "Delivery",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_Activities_ActivityId",
                table: "Delivery");

            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_Students_StudentId",
                table: "Delivery");

            migrationBuilder.DropIndex(
                name: "IX_Grade_DeliveryId",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "Especializacao",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "DeliveyDate",
                table: "Delivery");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Delivery");

            migrationBuilder.DropColumn(
                name: "Resolution",
                table: "Delivery");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentId",
                table: "Delivery",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "GradeId",
                table: "Delivery",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "SubmissionDate",
                table: "Delivery",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Grade_DeliveryId",
                table: "Grade",
                column: "DeliveryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_Activities_ActivityId",
                table: "Delivery",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_Students_StudentId",
                table: "Delivery",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
